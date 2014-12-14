using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.DXGI;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.Direct3D;
using SharpDX.D3DCompiler;
using System.Runtime.InteropServices;
using SharpDX.WIC;
using CRMWinApp.Rendering;

namespace CRMWinApp.UserControls
{


    struct ArkenConstantBuffer
    {
        public Matrix World { get; set; }
        public Matrix View { get; set; }
        public Matrix Projection { get; set; }
        public Matrix WVP { get; set; }
        public static int Size
        {
            get { return Marshal.SizeOf(typeof(ArkenConstantBuffer)); }
        }
    };
    public partial class RenderUC :SharpDX.Windows.RenderControl
    {


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing)
            {
                context.Dispose();
                AppDevice.Dispose();
                swapChain.Dispose();

                depthStencilView.Dispose();
                renderView.Dispose();
            }
            base.Dispose(disposing);
        }
        public static SharpDX.Direct3D11.Device AppDevice;
        public static SharpDX.Direct3D11.DeviceContext context;
        private RenderTargetView renderView = null;
        private SwapChain swapChain;

        private int clientWidth, clientHeight;


        private DepthStencilView depthStencilView;
        public int ClientHeight
        {
            get { return clientHeight; }
            set { clientHeight = value; }
        }

        public int ClientWidth
        {
            get { return clientWidth; }
            set { clientWidth = value; }
        }

        private Box box;
        private Map map;
        private Map map2;

        public RenderUC()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.UserPaint, true);
            UpdateStyles();


        }

        private void RenderUC_Load(object sender, EventArgs e)
        {

        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (!DesignMode)
            {
                InitGraphics();

                map = new Map(context);
                map.ClientHeight = clientHeight;
                map.ClientWidth = clientWidth;
                map.BitmapWidth = clientWidth;
                map.BitmapHeight = clientHeight;

                map.PosInScreenCoordinates = new Vector2(0, 0);
                map.PosIn3D = new Vector3(0, 0, -5);
                map.SrvPath = "C:\\Users\\alperen\\Documents\\Visual Studio 2013\\Projects\\CRMWinAppGitRelease\\CRMWinApp\\Textures\\prison_2f.jpg";
                map.ConstructGeometry(AppDevice);

                map2 = new Map(context);
                map2.ClientHeight = clientHeight;
                map2.ClientWidth = clientWidth;
                map2.BitmapWidth = 480;
                map2.BitmapHeight = 150;

                map2.PosInScreenCoordinates = new Vector2(150, 150);
                map2.PosIn3D = new Vector3(0, 0, -7);
                map2.SrvPath = "C:\\Users\\alperen\\Documents\\Visual Studio 2013\\Projects\\CRMWinAppGitRelease\\CRMWinApp\\Textures\\boxSelector.png";
                map2.ConstructGeometry(AppDevice);



            }
        }
        #region SOME USELESS SHIT
        private void InitGraphics()
        {
            var desc = new SwapChainDescription()
            {
                BufferCount = 1,
                ModeDescription =
                    new ModeDescription(this.ClientSize.Width, this.ClientSize.Height,
                                        new Rational(60, 1), Format.R8G8B8A8_UNorm),
                IsWindowed = true,
                OutputHandle = this.Handle,
                SampleDescription = new SampleDescription(1, 0),
                SwapEffect = SwapEffect.Discard,
                Usage = Usage.RenderTargetOutput,

            };
            SharpDX.Direct3D11.Device.CreateWithSwapChain(DriverType.Warp, DeviceCreationFlags.None, desc, out AppDevice, out swapChain);
            context = AppDevice.ImmediateContext;

            var backBuffer = Texture2D.FromSwapChain<Texture2D>(swapChain, 0);
            renderView = new RenderTargetView(AppDevice, backBuffer);


            //Depth Buffer thingy
            var zBufferTextureDescription = new Texture2DDescription
            {
                Format = Format.D16_UNorm,
                ArraySize = 1,
                MipLevels = 1,
                Width = clientWidth,
                Height = clientHeight,
                SampleDescription = new SampleDescription(1, 0),
                Usage = ResourceUsage.Default,
                BindFlags = BindFlags.DepthStencil,
                CpuAccessFlags = CpuAccessFlags.None,
                OptionFlags = ResourceOptionFlags.None,
            };
            using (var zBufferTexture = new Texture2D(AppDevice, zBufferTextureDescription))
                depthStencilView = new DepthStencilView(AppDevice, zBufferTexture);
            var depthStencilStateDesc = new DepthStencilStateDescription
            {
                IsDepthEnabled = false,
                DepthWriteMask = DepthWriteMask.All,
                DepthComparison = Comparison.Less,
                IsStencilEnabled = true,
                StencilReadMask = 0xFF,
                StencilWriteMask = 0xFF,
                FrontFace = new DepthStencilOperationDescription
                {
                    DepthFailOperation = StencilOperation.Increment,
                    PassOperation = StencilOperation.Keep,
                    FailOperation = StencilOperation.Keep,
                    Comparison = Comparison.Always,
                },
                BackFace = new DepthStencilOperationDescription
                {
                    DepthFailOperation = StencilOperation.Decrement,
                    PassOperation = StencilOperation.Keep,
                    FailOperation = StencilOperation.Keep,
                    Comparison = Comparison.Always,
                },
            };
            var depthStencilState = new DepthStencilState(AppDevice, depthStencilStateDesc);
            context.OutputMerger.SetDepthStencilState(depthStencilState);
            //



            RasterizerStateDescription rasdesc = new RasterizerStateDescription()
            {
                CullMode = CullMode.Back,
                FillMode = FillMode.Solid,
                IsFrontCounterClockwise = true,
                DepthBias = 0,
                DepthBiasClamp = 0,
                SlopeScaledDepthBias = 0,
                IsDepthClipEnabled = true,
                IsMultisampleEnabled = false,
                IsScissorEnabled = false,
                IsAntialiasedLineEnabled = false
            };
            context.Rasterizer.State = new RasterizerState(AppDevice, rasdesc);






            context.OutputMerger.SetTargets(depthStencilView, renderView);
            context.Rasterizer.SetViewport(new Viewport(0, 0, clientWidth, clientHeight, 0.0f, 1.0f));
        }
        #endregion

        public void Render()
        {
            context.ClearRenderTargetView(renderView, SharpDX.Color.Black);
            context.ClearDepthStencilView(depthStencilView, DepthStencilClearFlags.Depth, 1, 0);



            map.Render();
            map2.Render();

            swapChain.Present(0, PresentFlags.None);
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);


        }

    }
}
