using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class GameObjects
    {
        public int LevelListPosition { get; set; }

        public Camera camera { get; }
        public int DungeonRoomCount { get; set; }
        public IRoom currentRoom { get; private set; }

        public static GameObjects Instance { get; } = new GameObjects();



        public GameObjects()
        {
            LevelListPosition = 0;
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
            SpriteEffectSpriteFactory.Instance.LoadAllTextures(Game1.Instance.Content);
            SoundManager.Instance.LoadAllSounds(Game1.Instance.Content);
            SoundManager.Instance.PlayDungeonMusic();
            currentRoom = new Room();
            currentRoom.StoreRoom(LevelListPosition);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentRoom.Draw(spriteBatch);

        }

        public void UpdateRoom()
        {
            currentRoom = new Room();
            currentRoom.StoreRoom(LevelListPosition);
        }

        public void Update()
        {
            currentRoom.Update();
            camera.Update();

        }


    }
}
