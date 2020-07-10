using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint2;



namespace Sprint2
{
    public class GameObjects
    {
        public static int LevelListPosition { get; set; }
        public Camera camera { get; set; }

        private RoomClass currentRoom;
        public int DungeonRoomCount { get; set; }

        
        public GameObjects()
        {
            LevelListPosition = 1;
            camera = new Camera(Game1.Instance.GraphicsDevice.Viewport);
            DungeonRoomCount = 18;

        }




        public void LoadGameObjects()
        {
            ItemsSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            ProjectileSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            EnemySpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            NPCSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            BlockSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            BackgroundSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            currentRoom = new RoomClass();


        }


        public void Draw(SpriteBatch spriteBatch)
        {
            currentRoom.Draw(spriteBatch);
            camera.Draw(spriteBatch);
        }

        public void UpdateRoom()
        {
            currentRoom = new RoomClass();
            currentRoom.StoreRoom(LevelListPosition);
        }

        public void Update()
        {
   
            currentRoom.Update();
            camera.Update();
        }
    }

}
