using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2.Room
{
    public abstract class AbstractRoom : IRoom
    {

        protected IBackground Background { get; set; }

        protected int RoomNumber { get; set; }
        protected List<IItem> CurrentRoomItems { get; set; }

        protected List<INPC> CurrentRoomChars { get; set; }

        protected List<IBlock> CurrentRoomBlocks { get; set; }

        private IEnumerable<string> objectTypeData;
        private IEnumerable<string> objectNameData;
        private IEnumerable<string> locationData;
        private LevelXMLReader xmlreader;

        public void Draw(SpriteBatch spriteBatch)
        {

            Background.Draw(spriteBatch);

            foreach (IBlock block in CurrentRoomBlocks)
            {
                block.Draw(spriteBatch);
            }

            foreach (IItem item in CurrentRoomItems)
            {
                item.Draw(spriteBatch);
            }

            foreach (INPC character in CurrentRoomChars)
            {
                character.Draw(spriteBatch);
            }
        }

        public void Update()
        {

            foreach (IBlock block in CurrentRoomBlocks)
            {
                block.Update();
            }

            foreach (INPC character in CurrentRoomChars)
            {
                character.Update();
            }

            foreach (IItem item in CurrentRoomItems)
            {
                item.Update();
            }


        }

        public void StoreRoom()
        {
            xmlreader = new LevelXMLReader();

            objectTypeData =
                 from el in xmlreader.ReadXML()
                 where (int)el.Attribute("Room") == RoomNumber
                 select (string)el.Element("ObjectType");
             objectNameData =
                 from el in xmlreader.ReadXML()
                 where (int)el.Attribute("Room") == RoomNumber
                 select (string)el.Element("ObjectName");
             locationData = from el in xmlreader.ReadXML()
                            where (int)el.Attribute("Room") == RoomNumber
                            select (string)el.Element("Location");



            LoadRoom();

        }

        public void LoadRoom()
        {

            List<string> objectNameList = objectNameData.ToList();
            List<string> locationList = locationData.ToList();
            int objectlistPosition = 0;
            int locationlistPosition = 0;

            foreach (string str in objectTypeData)
            {
                switch (str)
                {

                    case "IBackground":
                        Background = ObjectStorage.backgroundObjectType[objectNameList[objectlistPosition]];
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IEnemy":
                        CurrentRoomChars.Add(ObjectStorage.charObjectType[objectNameList[objectlistPosition]]);
                        Vector2 newPostion = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))), int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)));
                        CurrentRoomChars[CurrentRoomChars.Count - 1].Position = newPostion;
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IItem":
                        CurrentRoomItems.Add(ObjectStorage.itemObjectType[objectNameList[objectlistPosition]]);
                        CurrentRoomItems[CurrentRoomItems.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))), int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)));
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IBlock":
                        CurrentRoomBlocks.Add(ObjectStorage.blockObjectType[objectNameList[objectlistPosition]]);
                        CurrentRoomBlocks[CurrentRoomChars.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))), int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)));
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
