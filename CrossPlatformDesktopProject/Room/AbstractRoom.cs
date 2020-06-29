using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Collision;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2.Room
{
    public abstract class AbstractRoom : IRoom
    {



        protected IBackground Background { get; set; }

        public int RoomNumber {get; set;}
        public List<IItem> CurrentRoomItems { get; set; }

        public List<INPC> CurrentRoomChars { get; set; }

        public List<IBlock> CurrentRoomBlocks { get; set; }

        public List<IPlayer> CurrentRoomPlayers { get; set; }

        public List<IProjectile> CurrentRoomProjectiles { get; set; }

        public List<IUsableItem> CurrentRoomUsableItems { get; set; }

        protected CollisionDetector collisionDetector { get; set; }
        protected CollisionHandler collisionHandler { get; set; }

        private IEnumerable<string> objectTypeData;
        private IEnumerable<string> objectNameData;
        private IEnumerable<string> locationData;
        private LevelXMLReader xmlreader;



        

        public void Draw(SpriteBatch spriteBatch)
        {

            Background.Draw(spriteBatch);
            if (CurrentRoomBlocks != null)
            {


                foreach (IBlock block in CurrentRoomBlocks)
                {
                    block.Draw(spriteBatch);
                }
            }

            if (CurrentRoomItems != null)
            {
                foreach (IItem item in CurrentRoomItems)
                {
                    item.Draw(spriteBatch);
                }
            }

            if (CurrentRoomChars != null)
            {
                foreach (INPC character in CurrentRoomChars)
                {
                    character.Draw(spriteBatch);
                }
            }

            if (CurrentRoomPlayers != null)
            {
                foreach (IPlayer player in CurrentRoomPlayers)
                {
                    player.Draw(spriteBatch);
                }
            }

            if (CurrentRoomProjectiles != null)
            {
                foreach (IProjectile projectile in CurrentRoomProjectiles)
                {
                    projectile.Draw(spriteBatch);
                }
            }
        }

        public void Update()
        {


            if (CurrentRoomBlocks != null)
            {
                foreach (IBlock block in CurrentRoomBlocks)
                {
                    block.Update();
                }
            }

            if (CurrentRoomItems != null)
            {
                foreach (IItem item in CurrentRoomItems)
                {
                    item.Update();
                }
            }

            if (CurrentRoomChars != null)
            {
                foreach (INPC character in CurrentRoomChars)
                {
                    character.Update();
                }
            }

            if (CurrentRoomPlayers != null)
            {
                foreach (IPlayer player in CurrentRoomPlayers)
                {
                    player.Update();
                }
            }

            if (CurrentRoomProjectiles != null)
            {
                foreach (IProjectile projectile in CurrentRoomProjectiles)
                {
                    projectile.Update();
                }
            }

            if (CurrentRoomUsableItems != null)
            {
                foreach (IUsableItem usableItem in CurrentRoomUsableItems)
                {
                    usableItem.Update();
                }
            }

            
           // collisionDetector.Update();
           // collisionHandler.Update();

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
            locationData = 
                from el in xmlreader.ReadXML()
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
                        Background = ObjectStorage.CreateBackgroundObject(objectNameList[objectlistPosition]);
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IEnemy":
                        CurrentRoomChars.Add(ObjectStorage.CreateCharObject(objectNameList[objectlistPosition]));
                        CurrentRoomChars[CurrentRoomChars.Count -1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))), int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)));
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "INPC":
                        CurrentRoomChars.Add(ObjectStorage.CreateCharObject(objectNameList[objectlistPosition]));
                        CurrentRoomChars[CurrentRoomChars.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))), int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)));
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IItem":
                        CurrentRoomItems.Add(ObjectStorage.CreateItemObject(objectNameList[objectlistPosition]));
                        CurrentRoomItems[CurrentRoomItems.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))), int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)));
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IBlock":
                        CurrentRoomBlocks.Add(ObjectStorage.CreateBlockObject(objectNameList[objectlistPosition]));
                        CurrentRoomBlocks[CurrentRoomBlocks.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))), int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)));
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
