﻿using Microsoft.Xna.Framework;
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
        

        public List<IController> Controllers { get; private set; }
        public IGameState State { get; set; }
        public PauseHUD PauseHUD { get; set; }
        public MiniHUD miniHUD { get; set; }
        public List<IPlayer> PlayerObjectList { get; set;  }
        public CollisionDetector CollisionDetector { get; set; }
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
            graphics.IsFullScreen = true;
            //graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            Console.WriteLine($"Screen Dimensions: {graphics.GraphicsDevice.Viewport.Width} x {graphics.GraphicsDevice.Viewport.Height}");
            this.IsMouseVisible = true;

            State = new StateGameStart(State);

            ItemsSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            ProjectileSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            EnemySpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            NPCSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            BackgroundSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            SpriteEffectSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            SoundManager.Instance.LoadAllSounds(Game1.Instance.Content);
            SoundManager.Instance.PlayDungeonMusic();
            objects = new GameObjects();

            Controllers = new List<IController>();
            Controllers.Add(new KeyboardController());
            Controllers.Add(new MouseController());

            LinkSpriteFactory.Instance.LoadAllTextures(Content);
            Link = new Link();

            HUDSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            MapSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            miniHUD = new MiniHUD(Link);
            PauseHUD = new PauseHUD(Link, miniHUD);

            CollisionDetector = new CollisionDetector();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            foreach (IController controller in Controllers)
            {
                controller.RegisterCommand();
            }
            miniHUD.LoadHUDTextures();
            PauseHUD.LoadHUDTextures();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            State.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            State.Draw(spriteBatch);
            base.Draw(gameTime);
        }

        public void Quit()
        {
            Exit();
            Environment.Exit(0);
        }
    }
}
