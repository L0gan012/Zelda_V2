using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sprint2
{
    public class LoadIntitalGame : IRoom
    {
        private List<INPC> currentRoomCharacterList;
        private List<IItem> currentRoomItemList;
        private GameObjects objects;
        private Queue<string> getRoomItems;

        public LoadIntitalGame(Game1 game)
        {
            objects = new GameObjects(game);
            currentRoomCharacterList = new List<INPC>();
            currentRoomItemList = new List<IItem>();
            getRoomItems = new Queue<string>();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void getRoomData()
        {

        }


        public void LoadObjectType()
        {
            objects.ReadXML(getRoomItems);
            while (getRoomItems.Count != 0)
            {
                string str = getRoomItems.Dequeue();
                switch (str)
                {
                    case "IItem":
                        objects.Items.Find((getRoomItems.Dequeue());
                        break;
                    case "INPC":
                        //currentRoomItemList.Add();
                        break;
                    default:
                        Console.WriteLine("Nothing");
                        break;
                }
            }
        }

        public void loadRoom()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
