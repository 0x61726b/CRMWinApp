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
    public partial class RenderUC : SharpDX.Windows.RenderControl
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

        private CRMDataModel dataContext = new CRMDataModel();

        private int clientWidth, clientHeight;
        private bool showHitboxes = true;

        private DepthStencilView depthStencilView;


        public delegate void OnCellClickedDelegate(Box b);
        public OnCellClickedDelegate OnCellClicked;

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

        private List<Box> hitBoxes = new List<Box>(20);
        public List<Map> prisonerPictures = new List<Map>();

        public RenderUC()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.UserPaint, true);
            UpdateStyles();


        }

        private void RenderUC_Load(object sender, EventArgs e)
        {

        }
        public void UpdatePictures()
        {
            var cells = dataContext.Cells.ToList();
            prisonerPictures.Clear();

            for (int i = 0; i < cells.Count(); ++i)
            {
                Models.Cell c = cells[i];

                if (c.Criminal != null)
                {
                    byte[] img = c.Criminal.PictureLeft;

                    Map m = new Map(context);
                    m.ClientWidth = clientWidth;
                    m.ClientHeight = clientHeight;
                    m.BitmapWidth = c.Width;
                    m.BitmapHeight = c.Height;
                    m.PosIn3D = new Vector3(0, 0, -7);
                    m.PosInScreenCoordinates = new Vector2(c.X, c.Y);
                    m.CreateTexture(AppDevice, img, c.Width, c.Height);
                    m.ConstructGeometry(AppDevice);
                    prisonerPictures.Add(m);
                }
            }
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
                map2.BitmapWidth = 272;
                map2.BitmapHeight = 23;

                map2.PosInScreenCoordinates = new Vector2(0, 15);
                map2.PosIn3D = new Vector3(0, 0, -7);
                map2.SrvPath = "C:\\Users\\alperen\\Documents\\Visual Studio 2013\\Projects\\CRMWinAppGitRelease\\CRMWinApp\\Textures\\boxSelector.png";
                map2.ConstructGeometry(AppDevice);


                var cells = dataContext.Cells.ToList();

                for (int i = 0; i < cells.Count(); ++i)
                {
                    Models.Cell c = cells[i];

                    box = new Box(context, c.Width, c.Height);
                    box.Cell = c;
                    box.ClientWidth = clientWidth;
                    box.ClientHeight = clientHeight;
                    box.PosIn3D = new Vector3(0, 0, -5);
                    box.PosInScreenCoordinates = new Vector2(c.X, c.Y);
                    box.ConstructGeometry(AppDevice);

                    hitBoxes.Add(box);

                    if (c.Criminal != null)
                    {
                        byte[] img = c.Criminal.PictureLeft;

                        Map m = new Map(context);
                        m.ClientWidth = clientWidth;
                        m.ClientHeight = clientHeight;
                        m.BitmapWidth = c.Width;
                        m.BitmapHeight = c.Height;
                        m.PosIn3D = new Vector3(0, 0, -7);
                        m.PosInScreenCoordinates = new Vector2(c.X, c.Y);
                        m.CreateTexture(AppDevice, img, c.Width, c.Height);
                        m.ConstructGeometry(AppDevice);
                        prisonerPictures.Add(m);
                    }
                }

                #region TEARS AHEAD THEREFORE TRY DESPAIR
                /*
                

                //B17
                box = new Box(context, 50, 22);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(45, 299);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //B16
                box = null;
                box = new Box(context, 50, 22);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(45, 324);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //B15
                box = null;
                box = new Box(context, 50, 22);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(45, 349);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //B18
                box = null;
                box = new Box(context, 50, 22);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(207, 349);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //B19
                box = null;
                box = new Box(context, 50, 22);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(207, 324);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //B20
                box = null;
                box = new Box(context, 50, 22);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(207, 299);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                
                //A17
                box = null;
                box = new Box(context, 39, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(493, 40);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //A16
                box = null;
                box = new Box(context, 39, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(535, 40);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //A15
                box = null;
                box = new Box(context, 39, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(579, 40);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //A20
                box = null;
                box = new Box(context, 39, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(493, 135);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //A19
                box = null;
                box = new Box(context, 39, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(535, 135);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //A18
                box = null;
                box = new Box(context, 39, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(579, 135);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);
                //

                //B8
                box = null;
                box = new Box(context, 45, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(266, 440);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //B7
                box = null;
                box = new Box(context, 40, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(313, 440);
                box.ConstructGeometry(AppDevice);

                hitBoxes.Add(box);

                //B6
                box = null;
                box = new Box(context, 42, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(363, 440);
                box.ConstructGeometry(AppDevice);


                hitBoxes.Add(box);

                //B5
                box = null;
                box = new Box(context, 42, 28);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(406, 440);
                box.ConstructGeometry(AppDevice);


                hitBoxes.Add(box);

                //A8
                box = null;
                box = new Box(context, 45, 23);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(735, 168);
                box.ConstructGeometry(AppDevice);


                hitBoxes.Add(box);

                //A7
                box = null;
                box = new Box(context, 45, 23);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(735, 195);
                box.ConstructGeometry(AppDevice);


                hitBoxes.Add(box);

                //A6
                box = null;
                box = new Box(context, 45, 23);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(735, 225);
                box.ConstructGeometry(AppDevice);


                hitBoxes.Add(box);

                box = null;
                box = new Box(context, 45, 23);
                box.ClientWidth = clientWidth;
                box.ClientHeight = clientHeight;
                box.PosIn3D = new Vector3(0, 0, -5);
                box.PosInScreenCoordinates = new Vector2(735, 250);
                box.ConstructGeometry(AppDevice);


                hitBoxes.Add(box);

                
                 * */
                #endregion
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

            for (int i = 0; i < hitBoxes.Count; ++i)
            {
                hitBoxes[i].Render(!showHitboxes);
            }

            for (int i = 0; i < prisonerPictures.Count; ++i)
            {
                prisonerPictures[i].Render();
            }

            swapChain.Present(0, PresentFlags.None);
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e); //44 298

            for (int i = 0; i < hitBoxes.Count; ++i)
            {
                Box b = hitBoxes[i];

                if (b.CheckForCollision(e.X, e.Y, (int)b.PosInScreenCoordinates.X, (int)b.PosInScreenCoordinates.Y, b.BitmapWidth, b.BitmapHeight))
                {
                    OnCellClicked(b);
                }
            }
        }

        private void RenderUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'q')
            {
                showHitboxes = !showHitboxes;
            }
        }

    }
}
