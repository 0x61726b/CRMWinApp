using CRMWinApp.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Direct3D11;
using SharpDX.D3DCompiler;
using System.Runtime.InteropServices;
using SharpDX;
using SharpDX.Direct3D;

namespace CRMWinApp.Rendering
{
    public struct VertexWithUV
    {
        Vector3 Pos;
        Vector2 Tex;

        public VertexWithUV(float x, float y, float z, float u, float v)
        {
            Pos.X = x;
            Pos.Y = y;
            Pos.Z = z;
            Tex.X = u;
            Tex.Y = v;
        }
    };
    public class Map
    {

        private VertexWithUV[] vertices;

        public VertexWithUV[] Vertices
        {
            get { return vertices; }
            set { vertices = value; }
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

        private ShaderResourceView _srv;

        public ShaderResourceView Srv
        {
            get { return _srv; }
            set { _srv = value; }
        }

        private SharpDX.Direct3D11.Buffer pVertexBuffer;
        private VertexShader              pVertexShader;
        private PixelShader               pPixelShader;
        private InputLayout               pInputLayout;

        private SharpDX.Direct3D11.Buffer pIndexBuffer;
        

        private SharpDX.Direct3D11.Buffer cBuffer;

        private DeviceContext context;
        private ArkenConstantBuffer cbPerFrame;

        private string _srvPath;

        public string SrvPath
        {
            get { return _srvPath; }
            set { _srvPath = value; }
        }
        private bool textureManuallyCreated = false;
        public Map(DeviceContext con)
        {
            context = con;
        }
        public void CreateTexture(Device device,byte[] img,int w,int h)
        {
            if (img == null)
                return;
            Resource t = Texture2D.FromMemory(device, img);
            
            
            ShaderResourceView srv = new ShaderResourceView(device,t);

            _srv = srv;
            textureManuallyCreated = true;

        }
        public void ConstructGeometry(Device AppDevice)
        {
            var vertexShaderByteCode = ShaderBytecode.CompileFromFile("..\\..\\Shaders\\VertexPixelShader.hlsl", "TextureVertexShader", "vs_4_0", ShaderFlags.None, EffectFlags.None);
            var vertexShader = new VertexShader(AppDevice, vertexShaderByteCode);

            var pixelShaderByteCode = ShaderBytecode.CompileFromFile("..\\..\\Shaders\\VertexPixelShader.hlsl", "TexturePixelShader", "ps_4_0", ShaderFlags.None, EffectFlags.None);
            var pixelShader = new PixelShader(AppDevice, pixelShaderByteCode);

            pVertexShader = vertexShader;
            pPixelShader = pixelShader;

            var layout = new InputLayout(
               AppDevice,
               ShaderSignature.GetInputSignature(vertexShaderByteCode),
               new[]
                    {
                        new InputElement("POSITION", 0, SharpDX.DXGI.Format.R32G32B32_Float, 0, 0),
                        new InputElement("TEXCOORD", 0, SharpDX.DXGI.Format.R32G32_Float, 12, 0)
                    });
            pInputLayout = layout;
            // 0 = -1,1
            // 1 = 1,1
            // 2 = 1,-1
            // 3 = -1,-1

            float left, right, top, bottom;

            float positionX, positionY;
            positionX = posInScreenCoordinates.X;
            positionY = posInScreenCoordinates.Y;

            

            left = (clientWidth / 2) * -1 + positionX;
            right = left + bitmapWidth;
            top = clientHeight / 2 - positionY;
            bottom = top - bitmapHeight;
            vertices = new VertexWithUV[]
                {
                    new VertexWithUV(left,top,0,0,0), //0
                    new VertexWithUV(left,bottom,0,0,1), //1
                    new VertexWithUV(right,bottom,0,1,1), //2
                   new VertexWithUV(right,top,0,1,0), 
                };

            indices = new int[]
                {
                    0,1,2,
                    0,2,3
                };
            var vertexBuffer = SharpDX.Direct3D11.Buffer.Create(AppDevice, BindFlags.VertexBuffer, vertices, Marshal.SizeOf(typeof(VertexWithUV)) * 4);
            var indexBuffer = SharpDX.Direct3D11.Buffer.Create(AppDevice, BindFlags.IndexBuffer, indices);

            pVertexBuffer = vertexBuffer;
            pIndexBuffer = indexBuffer;



            if (!textureManuallyCreated)
            {

                Srv = ShaderResourceView.FromFile(
                     AppDevice,
                     _srvPath);
            }


            cBuffer = new SharpDX.Direct3D11.Buffer(AppDevice, ArkenConstantBuffer.Size, ResourceUsage.Default, BindFlags.ConstantBuffer, CpuAccessFlags.None, ResourceOptionFlags.None, 0);
        }
        public void Render()
        {
            //set transformation matrix
            float ratio = (float)ClientWidth / (float)ClientHeight;
            Matrix projection = Matrix.OrthoLH(clientWidth, clientHeight, 0, 1);
            Matrix view = Matrix.LookAtLH(new Vector3(0,0,-5), new Vector3(0, 0, 0), Vector3.UnitY);
            Matrix world = Matrix.Identity;

            context.InputAssembler.InputLayout = pInputLayout;
            context.InputAssembler.SetIndexBuffer(pIndexBuffer, SharpDX.DXGI.Format.R32_UInt, 0);
            context.InputAssembler.PrimitiveTopology = PrimitiveTopology.TriangleList;
            context.InputAssembler.SetVertexBuffers(0, new VertexBufferBinding(pVertexBuffer, Marshal.SizeOf(typeof(VertexWithUV)), 0));

            context.VertexShader.Set(pVertexShader);
            context.PixelShader.Set(pPixelShader);

            context.PixelShader.SetShaderResource(0,_srv);
            Matrix WVP = world * view * projection;

            cbPerFrame = new ArkenConstantBuffer();
            cbPerFrame.View = view;
            cbPerFrame.Projection = projection;
            cbPerFrame.WVP = WVP;


            context.UpdateSubresource(ref cbPerFrame, cBuffer);
            context.VertexShader.SetConstantBuffer(0, cBuffer);

            context.DrawIndexed(6, 0, 0);
        }
    }
}
