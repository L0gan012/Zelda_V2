﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private GameObjects objects;
        private List<IController> controllers;

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

            controllers = new List<IController>();

            controllers.Add(new KeyboardController(this));
            controllers.Add(new MouseController(this));

            foreach(IController controller in controllers)
            {
                controller.RegisterCommand();
            }

            Link = new Link(this);

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
            foreach (IController controller in controllers)
            {
                controller.Update();
            }
            Link.Update();
            objects.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);
            objects.Draw(spriteBatch);
            Link.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
