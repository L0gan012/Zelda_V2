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
        private GameObjects objects;
        private List<IController> controllers;
        private SpriteFont spriteFont;

        public ILink Link { get; set; }

        public List<IPlayer> playerObjectList;

        public CollisionDetector collisionDetector;

        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEvents;

        public static Game1 Instance { get; } = new Game1();


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

            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            objects.LoadGameObjects();
            spriteFont = Content.Load<SpriteFont>("Fonts/Font");
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


            playerObjectList = new List<IPlayer>();

            playerObjectList.Add(Link);

            collisionDetector.Update(playerObjectList,
                GameObjects.LevelLoader.rooms[GameObjects.LevelListPosition].CurrentRoomChars,
                GameObjects.LevelLoader.rooms[GameObjects.LevelListPosition].CurrentRoomProjectiles,
                GameObjects.LevelLoader.rooms[GameObjects.LevelListPosition].CurrentRoomBlocks,
                GameObjects.LevelLoader.rooms[GameObjects.LevelListPosition].CurrentRoomItems,
                GameObjects.LevelLoader.rooms[GameObjects.LevelListPosition].CurrentRoomUsableItems);
      


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
            objects.Draw(spriteBatch);
            Link.Draw(spriteBatch);
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
