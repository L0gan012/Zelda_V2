using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont spriteFont;

        public List<IController> controllers;
        public IGameState state;
        public HeadsUpDisplay HUD;
        public List<IPlayer> playerObjectList;
        public CollisionDetector collisionDetector;
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEvents;

        public GameObjects objects { get; set; }
        public ILink Link { get; set; }

        public static Game1 Instance { get; } = new Game1();

        private Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 696;
            graphics.PreferredBackBufferWidth = 768;
            Content.RootDirectory = "Content";
            //graphics.IsFullScreen = true;
            //graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            Console.WriteLine($"Screen Dimensions: {graphics.GraphicsDevice.Viewport.Width} x {graphics.GraphicsDevice.Viewport.Height}");
            this.IsMouseVisible = true;

            state = new StateInLevel();
            objects = new GameObjects();
            objects.LoadGameObjects();

            controllers = new List<IController>();
            controllers.Add(new KeyboardController());
            controllers.Add(new MouseController());

            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            Link = new Link();

            HUDSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            MapSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            HUD = new HeadsUpDisplay(Link);

            collisionDetector = new CollisionDetector();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            foreach (IController controller in controllers)
            {
                controller.RegisterCommand();
            }
            HUD.LoadHUDTextures();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            state.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            state.Draw(spriteBatch);
            base.Draw(gameTime);
        }

        public void Quit()
        {
            Exit();
            Environment.Exit(0);
        }
    }
}
