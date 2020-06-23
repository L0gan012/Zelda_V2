using Sprint2.Backgrounds;
using Sprint2.Room;
using System.Collections.Generic;

namespace Sprint2
{
    public class LoadIntitalGame : AbstractRoom
    {
        private IBackground currentRoomBackGround;
        private LevelXMLReader xmlreader;

        public LoadIntitalGame(Game1 game)
        {
            xmlreader = new LevelXMLReader();
            RoomNumber = 1;
            CurrentRoomItems = new List<IItem>();
            CurrentRoomEnemies = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
        }


        public override void LoadRoom()
        {
            xmlreader.ReadXML(RoomNumber);
        }
    }
}
