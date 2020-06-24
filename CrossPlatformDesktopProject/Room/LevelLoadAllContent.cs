using System.Collections.Generic;

namespace Sprint2.Room
{
    public class LevelLoadAllContent
    {
        private Game1 game;
        public List<IRoom> rooms;

        public LevelLoadAllContent(Game1 game)
        {
            this.game = game;
            rooms = new List<IRoom>();
        }

        public void LoadAllContent()
        {
            rooms.Add(new RoomOne(game));
            rooms.Add(new RoomTwo(game));

        }
    }
}
