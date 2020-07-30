using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Game1 : Game
    {
        public GraphicsDeviceManager graphics { get; private set; }
        private SpriteBatch spriteBatch;
        private SpriteFont spriteFont;
        public List<IController> Controllers { get; private set; }
        public IGameState State { get; set; }
        public PauseHUD PauseHUD { get; set; }
        public MiniHUD miniHUD { get; set; }
        public List<IPlayer> PlayerObjectList { get; set; }
        public CollisionDetector CollisionDetector { get; set; }
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEvents;

        public ILink Link { get; set; }

        public int highestScore;
        public int currentScore;

        public static Game1 Instance { get; } = new Game1();

        private Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 696;
            graphics.PreferredBackBufferWidth = 768;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            this.IsMouseVisible = true;

            ItemsSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            ProjectileSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            EnemySpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            NPCSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            SpriteEffectSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            SoundManager.Instance.LoadAllSounds(Game1.Instance.Content);
            GameObjects.Instance.loadObjs();
            State = new StateSettings(State);



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

            highestScore = 0;
            currentScore = 0;

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
            spriteBatch.Begin();
            State.Draw(spriteBatch);
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
