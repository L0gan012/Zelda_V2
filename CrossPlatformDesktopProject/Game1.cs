using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint2.Controller;
using Sprint2.Factory;
using Sprint2.Player;
using Sprint2.Item;
using System.Runtime.InteropServices;
using Sprint2.Enemy_NPC;

namespace Sprint2
{

    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private ILink link;
        private IController controller;
        public static List<IItem> Items { get; set; }
        public static List<INPC> Enemies { get; set; }
        public static List<IBlock> Blocks { get; set; }
        public int ItemListPosition { get; set; }
        public int EnemyListPosition { get; set; }
        public int BlockListPosition { get; set; }
        public ItemLoadAllContent ItemLoader { get; set; }
        public EnemyLoadAllContent EnemyLoader { get; set; }
        public BlockLoadAllContent BlockLoader { get; set; }

        public List<IItem> ListOfItems
        { 
            get { return Items;}
            set { Items.Add((IItem)value); }
        }

        public List<INPC> ListOfEnemies
        {
            get { return Enemies; }
            set { Enemies.Add((IEnemy) value); }
        }

        public List<IBlock> ListOfBlocks
        {
            get { return Blocks; }
            set { Blocks.Add((IBlock)value); }
        }
        public ILink Link
        {
            get { return link; }
            set { link = value; }
        }
      
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

            Items = new List<IItem>();
            ItemLoader = new ItemLoadAllContent(this);

            Enemies = new List<INPC>();
            EnemyLoader = new EnemyLoadAllContent(this);

            Blocks = new List<IBlock>();
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
            Items[ItemListPosition].Update();
            Enemies[EnemyListPosition].Update();
            Blocks[BlockListPosition].Update();

            base.Update(gameTime);
         
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightGray);

            link.Draw(spriteBatch);
            Items[ItemListPosition].Draw(spriteBatch);
            Enemies[EnemyListPosition].Draw(spriteBatch);
            Blocks[BlockListPosition].Draw(spriteBatch, Constant.BlockStartPosition);

            base.Draw(gameTime);
        }

    }
}
