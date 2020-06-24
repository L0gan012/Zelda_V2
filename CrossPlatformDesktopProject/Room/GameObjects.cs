using Microsoft.Xna.Framework.Graphics;
using Sprint2.Room;
using System.Collections.Generic;

namespace Sprint2
{
    public class GameObjects
    {
        private ILink link;
        private Game1 game;

        /*These may not be needed. These just store the obj for the game in a list but they are not being used
         * any where. The objs that are store in "ObjectStorage.cs" with dic object type.
        public List<IItem> ListOfItems { get; set; }
        public List<INPC> ListOfEnemies { get; set; }
        public List<IBlock> ListOfBlocks { get; set; }
        public List<IBackground> ListOfBackgrounds { get;  set; }
        private ItemLoadAllContent ItemLoader { get; set; }
        private EnemyLoadAllContent EnemyLoader { get; set; }
        private BlockLoadAllContent BlockLoader { get; set; }
        private BackgroundLoadAllContent BackgroundLoader { get; set; }*/
        private LevelLoadAllContent LevelLoader { get; set; }
        public int LevelListPosition { get; set; }




        public GameObjects(Game1 game)
        {
            this.game = game;
            LevelListPosition = 1;

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
            //ObjectStorage.storeBlockObject();

            LevelLoader = new LevelLoadAllContent(game);
            LevelLoader.LoadAllContent();

            foreach(IRoom level in LevelLoader.rooms)
            {
                level.StoreRoom();
            }
        }


        public void Draw(SpriteBatch spriteBatch)
        {

           LevelLoader.rooms[LevelListPosition].Draw(spriteBatch);
            
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
