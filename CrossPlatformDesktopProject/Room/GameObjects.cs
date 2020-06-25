using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2.Room;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class GameObjects
    {
        private Game1 game;
        public static LevelLoadAllContent LevelLoader { get; set; }
        public static int LevelListPosition { get; set; }




        public GameObjects(Game1 game)
        {
            this.game = game;
            LevelListPosition = 0;
            LevelLoader = new LevelLoadAllContent();
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
            ObjectStorage.storeBlockObject();

            LevelLoader.LoadAllContent();


            foreach (IRoom level in LevelLoader.rooms)
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
