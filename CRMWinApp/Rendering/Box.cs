using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMWinApp.UserControls;
using SharpDX.Direct3D11;
using SharpDX.D3DCompiler;
using System.Runtime.InteropServices;
using SharpDX;
using SharpDX.Direct3D;



namespace CRMWinApp.Rendering
{
    public struct VertexWithColor
    {
        Vector3 Position;
        Vector4 Color;

        public VertexWithColor(float x, float y, float z, float r, float g, float b, float a)
        {
            Position.X = x;
            Position.Y = y;
            Position.Z = z;

            Color.X = r;
            Color.Y = g;
            Color.Z = b;
            Color.W = a;
        }
    };
    public class Box
    {
        private VertexWithColor[] vertices;

        public VertexWithColor[] Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }

        private VertexWithUV verticesMap;

        public VertexWithUV VerticesMap
        {
            get { return verticesMap; }
            set { verticesMap = value; }
        }


        private int[] indices;

        public int[] Indices
        {
            get { return indices; }
            set { indices = value; }
        }

        private int clientWidth;

        public int ClientWidth
        {
            get { return clientWidth; }
            set { clientWidth = value; }
        }

        private int clientHeight;

        public int ClientHeight
        {
            get { return clientHeight; }
            set { clientHeight = value; }
        }
        private int bitmapWidth;

        public int BitmapWidth
        {
            get { return bitmapWidth; }
            set { bitmapWidth = value; }
        }

        private int bitmapHeight;

        public int BitmapHeight
        {
            get { return bitmapHeight; }
            set { bitmapHeight = value; }
        }

        private Vector2 posInScreenCoordinates;

        public Vector2 PosInScreenCoordinates
        {
            get { return posInScreenCoordinates; }
            set { posInScreenCoordinates = value; }
        }

        private Vector3 posIn3D;

        public Vector3 PosIn3D
        {
            get { return posIn3D; }
            set { posIn3D = value; }
        }


        private SharpDX.Direct3D11.Buffer pVertexBuffer;
        private SharpDX.Direct3D11.Buffer pIndexBuffer;
        private SharpDX.Direct3D11.Buffer cBuffer;

        private VertexShader pVertexShader;
        private PixelShader pPixelShader;
        private InputLayout pInputLayout;

        private DeviceContext context;
        private ArkenConstantBuffer cbPerFrame;
        private Models.Cell c;

        public Models.Cell Cell
        {
            get { return c; }
            set { c = value; }
        }


        public Box(DeviceContext con, int w, int h)
        {
            context = con;

            bitmapWidth = w;
            bitmapHeight = h;

            indices = new int[] { 0, 1, 2, 0, 2, 3 };
        }

        public void ConstructGeometry(Device AppDevice)
        {
            var vertexShaderByteCode = ShaderBytecode.CompileFromFile("..\\..\\Shaders\\VertexColorShader.hlsl", "TCSV", "vs_4_0", ShaderFlags.None, EffectFlags.None);
            var vertexShader = new VertexShader(AppDevice, vertexShaderByteCode);

            var pixelShaderByteCode = ShaderBytecode.CompileFromFile("..\\..\\Shaders\\VertexColorShader.hlsl", "TCSP", "ps_4_0", ShaderFlags.None, EffectFlags.None);
            var pixelShader = new PixelShader(AppDevice, pixelShaderByteCode);

            pVertexShader = vertexShader;
            pPixelShader = pixelShader;

            var layout = new InputLayout(
               AppDevice,
               ShaderSignature.GetInputSignature(vertexShaderByteCode),
               new[]
                    {
                        new InputElement("POSITION", 0, SharpDX.DXGI.Format.R32G32B32_Float, 0, 0),
                        new InputElement("COLOR", 0, SharpDX.DXGI.Format.R32G32B32A32_Float, 12, 0)
                    });

            // 0 = -1,1
            // 1 = 1,1
            // 2 = 1,-1
            // 3 = -1,-1

            pInputLayout = layout;
            FormVertices();



            var vertexBuffer = SharpDX.Direct3D11.Buffer.Create(AppDevice, BindFlags.VertexBuffer, vertices, Marshal.SizeOf(typeof(VertexWithColor)) * 4, ResourceUsage.Dynamic, CpuAccessFlags.Write, ResourceOptionFlags.None, 0);
            var indexBuffer = SharpDX.Direct3D11.Buffer.Create(AppDevice, BindFlags.IndexBuffer, indices);
            cBuffer = new SharpDX.Direct3D11.Buffer(AppDevice, ArkenConstantBuffer.Size, ResourceUsage.Default, BindFlags.ConstantBuffer, CpuAccessFlags.None, ResourceOptionFlags.None, 0);

            pVertexBuffer = vertexBuffer;
            pIndexBuffer = indexBuffer;


        }
        public void FormVertices()
        {
            float left, right, top, bottom;

            float positionX, positionY;
            positionX = posInScreenCoordinates.X;
            positionY = PosInScreenCoordinates.Y;



            left = (clientWidth / 2) * -1 + positionX;
            right = left + bitmapWidth;
            top = clientHeight / 2 - positionY;
            bottom = top - bitmapHeight;
            VertexWithColor[] v = new[]
                {
                    new VertexWithColor(left,top,0,1,0,0,0), //0
                    new VertexWithColor(left,bottom,0,1,0,0,0), //1
                    new VertexWithColor(right,bottom,0,1,0,0,0), //2
                   new VertexWithColor(right,top,0,1,0,0,0),  //3
                };
            vertices = v;
        }
        public void UpdateBox()
        {
            FormVertices();

            DataStream ds;
            var dataBox = context.MapSubresource(pVertexBuffer, MapMode.WriteDiscard, SharpDX.Direct3D11.MapFlags.None, out ds);
            ds.WriteRange(vertices);
            context.UnmapSubresource(pVertexBuffer, 0);
            ds.Dispose();
        }
        public void Render(bool show)
        {
            //set transformation matrix
            float ratio = (float)ClientWidth / (float)ClientHeight;
            Matrix projection = Matrix.OrthoLH(clientWidth, clientHeight, 1, 10);
            Matrix view = Matrix.LookAtLH(posIn3D, new Vector3(0, 0, 0), Vector3.UnitY);
            Matrix world = Matrix.Identity;

            context.InputAssembler.InputLayout = pInputLayout;
            context.InputAssembler.SetIndexBuffer(pIndexBuffer, SharpDX.DXGI.Format.R32_UInt, 0);
            context.InputAssembler.PrimitiveTopology = PrimitiveTopology.TriangleList;
            context.InputAssembler.SetVertexBuffers(0, new VertexBufferBinding(pVertexBuffer, Marshal.SizeOf(typeof(VertexWithColor)), 0));

            context.VertexShader.Set(pVertexShader);
            context.PixelShader.Set(pPixelShader);

            Matrix WVP = world * view * projection;

            cbPerFrame = new ArkenConstantBuffer();
            cbPerFrame.View = view;
            cbPerFrame.Projection = projection;
            cbPerFrame.WVP = WVP;


            context.UpdateSubresource(ref cbPerFrame, cBuffer);
            context.VertexShader.SetConstantBuffer(0, cBuffer);

            if( show )
                context.DrawIndexed(6, 0, 0);
        }

        public bool CheckForCollision(int mx,int my,int x,int y,int w,int h)
        {
            return (mx > x && mx <= x + w && my > y && my <= y + h);
        }
    }
}
