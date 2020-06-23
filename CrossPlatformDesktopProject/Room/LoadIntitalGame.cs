using Sprint2.Backgrounds;
using Sprint2.Room;
using System.Collections.Generic;

namespace Sprint2
{
    public class LoadIntitalGame : AbstractRoom
    {
        private LevelXMLReader xmlreader;
        private IEnumerable<String> roomData;

        public LoadIntitalGame(Game1 game)
        {
            xmlreader = new LevelXMLReader();
            RoomNumber = 1;
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
