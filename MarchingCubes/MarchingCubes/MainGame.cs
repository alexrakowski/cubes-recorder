using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MarchingCubes
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class MainGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        MainForm _form;
        CubesInfo _cubesInfo;
        Matrix world, view, projection;

        public MainGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        #region Form Integration
        public MainGame(MainForm form)
        {
            _form = form;
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferWidth = _form.ViewportSize.Width,
                PreferredBackBufferHeight = _form.ViewportSize.Height
            };

            graphics.PreparingDeviceSettings += graphics_PreparingDeviceSettings;
            System.Windows.Forms.Control.FromHandle(Window.Handle).VisibleChanged += MainGame_VisibleChanged;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        void MainGame_VisibleChanged(object sender, System.EventArgs e)
        {
            if (System.Windows.Forms.Control.FromHandle(Window.Handle).Visible)
                System.Windows.Forms.Control.FromHandle(Window.Handle).Visible = false;
        }

        void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = _form.CanvasHandle;
        }
        #endregion

        #region Marching Cubes
        private void DrawMarchingCubes()
        {
            Algorithm.Poligonizator.Init(_cubesInfo.DimensionSize - 1, GetRandomGdata(_cubesInfo.DimensionSize),
                        this.GraphicsDevice);
            var primitives = Algorithm.Poligonizator.Process(this.GraphicsDevice, _cubesInfo.IsoLevel);

            if (primitives.VertexCount > 0)
            {
                primitives.InitializePrimitive(this.GraphicsDevice);
                primitives.Draw(world, view, projection, _cubesInfo.Color);
            }
        }

        private double[, ,] GetRandomGdata(int dimSize)
        {
            double[, ,] gData = new double[dimSize, dimSize, dimSize];
            Random rand = _cubesInfo.GetRandom();
            for (int x = 0; x < dimSize; ++x)
            {
                for (int y = 0; y < dimSize; ++y)
                {
                    for (int z = 0; z < dimSize; ++z)
                    {
                        gData[x, y, z] = rand.NextDouble();
                    }
                }
            }
            return gData;
        }
        #endregion

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            _cubesInfo = CubesInfo.Default;
            _form.SetCubesInfo(_cubesInfo);

            // Don't perform any transformations
            world = Matrix.Identity;

            // Place the camera at vector (5,5,5) and look at vector (0,0,0)
            view = Matrix.CreateLookAt(new Vector3(30, 30, 30), new Vector3(0, 0, 0), Vector3.Up);

            // Create the projection
            projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.PiOver4, GraphicsDevice.Viewport.AspectRatio, 0.1f, 100.0f);
 

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            DrawMarchingCubes();

            base.Draw(gameTime);
        }
    }
}
