using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2.Room;



namespace Sprint2
{
    public class GameObjects
    {
        private Game1 game;
        public static LevelLoadAllContent LevelLoader { get; set; }
        public static int LevelListPosition { get; set; }




        public GameObjects()
        {
            LevelListPosition = 0;
            LevelLoader = new LevelLoadAllContent();

        }

      


        public void LoadGameObjects()
        {
            ItemsSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            ProjectileSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            EnemySpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            NPCSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            BackgroundSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            

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
