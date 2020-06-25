using System.Collections.Generic;

namespace Sprint2.Room
{
    public class LevelLoadAllContent
    {
        public List<IRoom> rooms;

        public LevelLoadAllContent()
        {
            rooms = new List<IRoom>();
        }

        public void LoadAllContent()
        {
            rooms.Add(new RoomOne());
            rooms.Add(new RoomTwo());

        }
    }
}
