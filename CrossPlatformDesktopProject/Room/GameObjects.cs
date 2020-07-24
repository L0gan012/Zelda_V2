using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class GameObjects
    {
        public int LevelListPosition { get; set; }

        public int DungeonRoomCount { get; set; }
        public IRoom currentRoom { get; set; }

        public static GameObjects Instance { get; } = new GameObjects();



        public GameObjects()
        {
            LevelListPosition = 32;
            DungeonRoomCount = 36;

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
            

        }

    }
}
