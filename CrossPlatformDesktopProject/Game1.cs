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
        public GameObjects objects { get; set; }
        public List<IController> controllers;
        private SpriteFont spriteFont;

        public IGameState state;

        public ILink Link { get; set; }

        public List<IPlayer> playerObjectList;

        public CollisionDetector collisionDetector;

        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEvents;

        public HeadsUpDisplay HUD;

        public static Game1 Instance { get; } = new Game1();


        private Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            //graphics.PreferredBackBufferHeight = 600;
            //graphics.PreferredBackBufferWidth = 1920;
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = true;
            //graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            Console.WriteLine($"Screen Dimensions: {graphics.GraphicsDevice.Viewport.Width} x {graphics.GraphicsDevice.Viewport.Height}");
            this.IsMouseVisible = true;

            state = new StateInLevel();
            objects = new GameObjects();

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
            objects.LoadGameObjects();
            HUD.LoadHUDTextures();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            state.Update();
            /*
            foreach (IController controller in controllers)
            {
                controller.Update();
            }
            Link.Update();
            objects.Update();
            state.Update();
            HUD.Update();

            playerObjectList = new List<IPlayer>();

            playerObjectList.Add(Link);

            collisionDetector.Update(playerObjectList,
                RoomClass.CurrentRoomChars,
                RoomClass.CurrentRoomProjectiles,
                RoomClass.CurrentRoomBlocks,
                RoomClass.CurrentRoomItems,
                RoomClass.CurrentRoomUsableItems);
            */
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            state.Draw(spriteBatch);
            /* GraphicsDevice.Clear(Color.LightGray);
             objects.Draw(spriteBatch);
             Link.Draw(spriteBatch);
             state.Draw(spriteBatch);
             HUD.Draw(spriteBatch);
             spriteBatch.Begin();
             //spriteBatch.DrawString(spriteFont, "This is a test", Vector2.Zero, Color.Black);
             spriteBatch.End();*/


            base.Draw(gameTime);
        }

        public void Quit()
        {
            Exit();
            Environment.Exit(0);
        }
    }
}
