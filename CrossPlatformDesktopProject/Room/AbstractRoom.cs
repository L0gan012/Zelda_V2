using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2.Room
{
    public abstract class AbstractRoom : IRoom
    {
        private IEnumerable<string> objectTypeData;
        private IEnumerable<string> objectNameData;
        private IEnumerable<string> locationData;
        private LevelXMLReader xmlreader;

        protected IBackground Background { get; set; }
        public int RoomNumber { get; set; }
        public List<IItem> CurrentRoomItems { get; set; }
        public List<INPC> CurrentRoomChars { get; set; }
        public List<IBlock> CurrentRoomBlocks { get; set; }
        public List<IPlayer> CurrentRoomPlayers { get; set; }
        public List<IProjectile> CurrentRoomProjectiles { get; set; }
        public List<IUsableItem> CurrentRoomUsableItems { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            Background.Draw(spriteBatch);

            DrawGameObjectList(spriteBatch, CurrentRoomItems.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomChars.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomBlocks.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomPlayers.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomProjectiles.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomUsableItems.Cast<IGameObject>().ToList());
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
                Queue<IItem> removableItems = new Queue<IItem>();

                foreach (IItem item in CurrentRoomItems)
                {
                    item.Update();
                    if (item.IsDestructable)
                    {
                        removableItems.Enqueue(item);
                    }
                }

                while(removableItems.Count > 0)
                {
                    IItem item = removableItems.Dequeue();
                    CurrentRoomItems.Remove(item);
                }
            }

            if (CurrentRoomChars != null)
            {
                Queue<INPC> deadChars = new Queue<INPC>();

                foreach (INPC character in CurrentRoomChars)
                {
                    character.Update();
                    if (character.IsDestructable)
                    {
                        deadChars.Enqueue(character);
                    }
                }

                while (deadChars.Count > 0)
                {
                    INPC character = deadChars.Dequeue();
                    CurrentRoomChars.Remove(character);
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
                Queue<IProjectile> deadProjectiles = new Queue<IProjectile>();

                foreach (IProjectile projectile in CurrentRoomProjectiles)
                {
                    projectile.Update();
                    if (projectile.IsDestructable)
                    {
                        deadProjectiles.Enqueue(projectile);
                    }
                }
                
                while (deadProjectiles.Count > 0)
                {
                    IProjectile projectile = deadProjectiles.Dequeue();
                    CurrentRoomProjectiles.Remove(projectile);
                }
            }

            if (CurrentRoomUsableItems != null)
            {
                Queue<IUsableItem> deadUsableItems = new Queue<IUsableItem>();
                foreach (IUsableItem usableItem in CurrentRoomUsableItems)
                {
                    usableItem.Update();
                    if (usableItem.IsDestructable)
                    {
                        deadUsableItems.Enqueue(usableItem);
                    }
                }
                
                while (deadUsableItems.Count > 0)
                {
                    IUsableItem usableItem = deadUsableItems.Dequeue();
                    CurrentRoomUsableItems.Remove(usableItem);
                }
            }
        }

        private void DrawGameObjectList(SpriteBatch spriteBatch, List<IGameObject> list)
        {
            if (list != null)
            {
                foreach (IGameObject item in list)
                {
                    item.Draw(spriteBatch);
                }
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
