using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Collision;
using Sprint2.Room;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private GameObjects objects;
        private List<IController> controllers;
        private static Game1 instance = new Game1();


        public ILink Link { get; set; }

        public CollisionDetector collisionDetector;
        public CollisionHandler collisionHandler;

        public static Game1 Instance
        {
            get
            {
                return instance;
            }
        }


        private Game1()
        {
            graphics = new GraphicsDeviceManager(this); 
            graphics.IsFullScreen = false;
            //graphics.PreferredBackBufferHeight = Constant.RooomDisplayHeight;
            //graphics.PreferredBackBufferWidth = Constant.RooomDisplayWidth;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            this.IsMouseVisible = true;

            objects = new GameObjects();

            controllers = new List<IController>();

            controllers.Add(new KeyboardController());
            controllers.Add(new MouseController());

            foreach(IController controller in controllers)
            {
                controller.RegisterCommand();
            }

            Link = new Link();

            LinkSpriteFactory.Instance.LoadAllTextures(Content);

            ICommand reset = new ResetCommand();
            reset.Execute();

            collisionDetector = new CollisionDetector();
            collisionHandler = new CollisionHandler();
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            objects.LoadGameObjects();

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            foreach (IController controller in controllers)
            {
                controller.Update();
            }
            Link.Update();
            objects.Update();

          //  collisionDetector.Update();
           // collisionHandler.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
            objects.Draw(spriteBatch);
            Link.Draw(spriteBatch);

            base.Draw(gameTime);
        }

        public void Quit()
        {
            Exit();
            Environment.Exit(0);
        }
    }
}
