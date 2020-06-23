using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private GameObjects objects;
        private IController controller;
        public ILink Link { get; set; }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            this.IsMouseVisible = true;

            objects = new GameObjects(this);

            controller = new KeyboardController(this);
            controller.RegisterCommand();

            LinkSpriteFactory.Instance.LoadAllTextures(Content);

            ICommand reset = new ResetCommand(this);
            reset.Execute();
            
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
            controller.Update();
            Link.Update();
            objects.Update();


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);

            Link.Draw(spriteBatch);
            objects.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
