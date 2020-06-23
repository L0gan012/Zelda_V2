using Microsoft.Xna.Framework.Graphics;
using Sprint2.Backgrounds;
using Sprint2.Room;
using System.Collections.Generic;

namespace Sprint2
{
    public class GameObjects
    {
        private ILink link;
        private Game1 game;

        public List<IItem> ListOfItems { get; set; }
        public List<INPC> ListOfEnemies { get; set; }
        public List<IBlock> ListOfBlocks { get; set; }
        public List<IBackground> ListOfBackgrounds { get;  set; }

        private ItemLoadAllContent ItemLoader { get; set; }
        private EnemyLoadAllContent EnemyLoader { get; set; }
        private BlockLoadAllContent BlockLoader { get; set; }
        private LevelLoadAllContent LevelLoader { get; set; }
        private BackgroundLoadAllContent BackgroundLoader { get; set; }



        public GameObjects(Game1 game)
        {
            this.game = game;


            ListOfItems = new List<IItem>();
            ListOfEnemies = new List<INPC>();
            ListOfBlocks = new List<IBlock>();
            ListOfBackgrounds = new List<IBackground>();

            

        }

      


        public void LoadGameObjects()
        {
            ItemsSpriteFactory.Instance.LoadAllTextures(game.Content);
            ProjectileSpriteFactory.Instance.LoadAllTextures(game.Content);
            EnemySpriteFactory.Instance.LoadAllTextures(game.Content);
            NPCSpriteFactory.Instance.LoadAllTextures(game.Content);
            BlockSpriteFactory.Instance.LoadAllTextures(game.Content);
            BackgroundSpriteFactory.Instance.LoadAllTextures(game.Content);

            ObjectStorage.storeItemObject();
            ObjectStorage.storeCharObject();
            ObjectStorage.storeBackgroundObject();

            ItemLoader = new ItemLoadAllContent(game);
            EnemyLoader = new EnemyLoadAllContent(game);
            BlockLoader = new BlockLoadAllContent(game);
            BackgroundLoader = new BackgroundLoadAllContent(game);
            LevelLoader = new LevelLoadAllContent(game);

            ItemLoader.LoadContent();
            EnemyLoader.LoadContent();
            BlockLoader.LoadContent();
            BackgroundLoader.LoadContent();
            LevelLoader.LoadAllContent();

            foreach(IRoom level in LevelLoader.rooms)
            {
                level.StoreRoom();
            }
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (IRoom level in LevelLoader.rooms)
            {
                level.Draw(spriteBatch);
            }
        }

        public void Update()
        {
            foreach (IRoom level in LevelLoader.rooms)
            {
                level.Update();
            }
        }
    }

}
