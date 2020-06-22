using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private IController controller;

        public ILink Link { get; set; }
        public List<IItem> ListOfItems { get; set; }
        public List<INPC> ListOfEnemies { get; set; }
        public List<IBlock> ListOfBlocks { get; set; }
        public int ItemListPosition { get; set; }
        public int EnemyListPosition { get; set; }
        public int BlockListPosition { get; set; }
        public ItemLoadAllContent ItemLoader { get; set; }
        public EnemyLoadAllContent EnemyLoader { get; set; }
        public BlockLoadAllContent BlockLoader { get; set; }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            this.IsMouseVisible = true;

            controller = new KeyboardController(this);

            controller.RegisterCommand();

            LinkSpriteFactory.Instance.LoadAllTextures(Content);

            ListOfItems = new List<IItem>();
            ItemLoader = new ItemLoadAllContent(this);

            ListOfEnemies = new List<INPC>();
            EnemyLoader = new EnemyLoadAllContent(this);

            ListOfBlocks = new List<IBlock>();
            BlockLoader = new BlockLoadAllContent(this);

            ICommand reset = new ResetCommand(this);
            reset.Execute();
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            ItemsSpriteFactory.Instance.LoadAllTextures(Content);
            ProjectileSpriteFactory.Instance.LoadAllTextures(Content);
            EnemySpriteFactory.Instance.LoadAllTextures(Content);
            NPCSpriteFactory.Instance.LoadAllTextures(Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Content);

            ItemLoader.LoadContent();
            EnemyLoader.LoadContent();
            BlockLoader.LoadContent();
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            controller.Update();
            Link.Update();
            ListOfItems[ItemListPosition].Update();
            ListOfEnemies[EnemyListPosition].Update();
            ListOfBlocks[BlockListPosition].Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);

            Link.Draw(spriteBatch);
            ListOfItems[ItemListPosition].Draw(spriteBatch);
            ListOfEnemies[EnemyListPosition].Draw(spriteBatch);
            ListOfBlocks[BlockListPosition].Draw(spriteBatch, Constant.BlockStartPosition);
            
            base.Draw(gameTime);
        }
    }
}
