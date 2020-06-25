using System.Collections.Generic;

namespace Sprint2.Room
{
    public class LevelLoadAllContent
    {
        public List<IRoom> rooms { get; }

        public LevelLoadAllContent()
        {
            rooms = new List<IRoom>();
        }

        public void LoadAllContent()
        {
            rooms.Add(new RoomOne());
            rooms.Add(new RoomTwo());
            rooms.Add(new RoomThree());
            rooms.Add(new RoomFour());
            rooms.Add(new RoomFive());
            rooms.Add(new RoomSix());
            rooms.Add(new RoomSeven());
            rooms.Add(new RoomEight());
            rooms.Add(new RoomNine());
            rooms.Add(new RoomTen());
            rooms.Add(new RoomEleven());
            rooms.Add(new RoomTwelve());
            rooms.Add(new RoomThirteen());
            rooms.Add(new RoomFourteen());
            rooms.Add(new RoomFifteen());

        }
    }
}
