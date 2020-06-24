using Sprint2.Room;
using System.Linq;
using System.Collections.Generic;

namespace Sprint2
{
    public class RoomTwo : AbstractRoom
    {
        private LevelXMLReader xmlreader;
        private IEnumerable<string> roomData;

        public RoomTwo(Game1 game)
        {
            xmlreader = new LevelXMLReader();
            RoomNumber = 2;
            CurrentRoomItems = new List<IItem>();
            CurrentRoomEnemies = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
        }


        public override void StoreRoom()
        {

            roomData =
                from el in xmlreader.ReadXML()
                where (int)el.Attribute("Room") == RoomNumber
                select (string)el.Element("ObjectName");
            LoadRoom();
        }

        public override void LoadRoom()
        {
            foreach (string str in roomData)
            {
                Background = ObjectStorage.backgroundObjectType[str];
            }
        }

    }
}
