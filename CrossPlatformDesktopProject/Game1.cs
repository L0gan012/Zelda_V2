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
        public IGameState state;
        public GameObjects objects { get; set; }
        public List<IController> controllers;
        private SpriteFont spriteFont;


        public ILink Link { get; set; }

        public List<IPlayer> playerObjectList;

        public CollisionDetector collisionDetector;

        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEvents;
       
        public static Game1 Instance { get; } = new Game1();


        private Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            //graphics.PreferredBackBufferHeight = Constant.RooomDisplayHeight;
            //graphics.PreferredBackBufferWidth = Constant.RooomDisplayWidth;

        //    graphics.PreferredBackBufferWidth = GraphicsDevice.DisplayMode.Width;
         //   graphics.PreferredBackBufferHeight = GraphicsDevice.DisplayMode.Height;
        //    graphics.IsFullScreen = true;
        //    graphics.ApplyChanges();

            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            this.IsMouseVisible = true;

            state = new StateInLevel(this);
            objects = new GameObjects();

            controllers = new List<IController>();
            controllers.Add(new KeyboardController());
            controllers.Add(new MouseController());

            Link = new Link();
            LinkSpriteFactory.Instance.LoadAllTextures(Content);

            ICommand reset = new ResetCommand();
            reset.Execute();

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
            spriteFont = Content.Load<SpriteFont>("Fonts/Font");
            objects.LoadGameObjects();

        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {

            state.Update();
            
            foreach (IController controller in controllers)
            {
                controller.Update();
            }
            Link.Update();
            objects.Update();

            playerObjectList = new List<IPlayer>();

            playerObjectList.Add(Link);

            collisionDetector.Update(playerObjectList,
                RoomClass.CurrentRoomChars,
                RoomClass.CurrentRoomProjectiles,
                RoomClass.CurrentRoomBlocks,
                RoomClass.CurrentRoomItems,
                RoomClass.CurrentRoomUsableItems);
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            //spriteBatch.Begin();

            GraphicsDevice.Clear(Color.LightGray);
            state.Draw(spriteBatch);
            
            objects.Draw(spriteBatch);
            Link.Draw(spriteBatch);
            
            state.Draw(spriteBatch);
            spriteBatch.Begin();
            spriteBatch.DrawString(spriteFont, "This is a test", Vector2.Zero, Color.Black);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void Quit()
        {
            Exit();
            Environment.Exit(0);
        }
    }
}
