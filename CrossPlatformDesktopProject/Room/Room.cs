using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2
{
    public class Room : IRoom
    {
        private IEnumerable<string> objectTypeData;
        private IEnumerable<string> objectNameData;
        private IEnumerable<string> locationData;
        private LevelXMLReader xmlReader;
        private LevelXMLWriter xmlWriter;

        private UpdateRoomObjects updateObjsInRoom;

        public List<Enumerations.Direction> doorDirections { get; set; } = new List<Enumerations.Direction>();
        public static List<IItem> CurrentRoomItems { get; set; }
        public static List<INPC> CurrentRoomChars { get; set; }
        public static List<IBlock> CurrentRoomBlocks { get; set; }
        public static List<IPlayer> CurrentRoomPlayers { get; set; }
        public static List<IProjectile> CurrentRoomProjectiles { get; set; }
        public static List<IUsableItem> CurrentRoomUsableItems { get; set; }
        public static List<ISpriteEffect> CurrentRoomSpriteEffects { get; set; }
        public static List<IDoorTrigger> CurrentRoomDoorTriggers { get; set; }
        public static List<int> GridNumbers { get; set; }




        public Room()
        {
            CurrentRoomItems = new List<IItem>();
            CurrentRoomChars = new List<INPC>();
            CurrentRoomBlocks = new List<IBlock>();
            CurrentRoomPlayers = new List<IPlayer>();
            CurrentRoomProjectiles = new List<IProjectile>();
            CurrentRoomUsableItems = new List<IUsableItem>();
            CurrentRoomSpriteEffects = new List<ISpriteEffect>();
            CurrentRoomDoorTriggers = new List<IDoorTrigger>();
            GridNumbers = new List<int>();
            storeGridNumber();
            xmlReader = new LevelXMLReader();
            xmlWriter = new LevelXMLWriter();
            updateObjsInRoom = new UpdateRoomObjects();

        }

        public void Draw(SpriteBatch spriteBatch)
        {

            DrawGameObjectList(spriteBatch, CurrentRoomBlocks.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomItems.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomChars.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomPlayers.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomProjectiles.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomUsableItems.Cast<IGameObject>().ToList());
            DrawGameObjectList(spriteBatch, CurrentRoomDoorTriggers.Cast<IGameObject>().ToList());
            foreach(ISpriteEffect spriteEffect in CurrentRoomSpriteEffects)
            {
                spriteEffect.Draw(spriteBatch);
            }

        }

        public void Update()
        {
            updateObjsInRoom.UpdateBlock(CurrentRoomBlocks);
            updateObjsInRoom.UpdateItem(CurrentRoomItems);
            updateObjsInRoom.UpdateChar(CurrentRoomChars);
            updateObjsInRoom.UpdatePlayer(CurrentRoomPlayers);
            updateObjsInRoom.UpdateProjecticles(CurrentRoomProjectiles);
            updateObjsInRoom.UpdateUseableItems(CurrentRoomUsableItems);
            updateObjsInRoom.UpdateSpriteEffects(CurrentRoomSpriteEffects);
            updateObjsInRoom.UpdateDoorTriggers(CurrentRoomDoorTriggers);

        }

        private void DrawGameObjectList(SpriteBatch spriteBatch, List<IGameObject> list)
        {
            if (list != null)
            {
                foreach (IGameObject currentGameObject in list)
                {
                    currentGameObject.Draw(spriteBatch);
                }
            }
        }

        public void UpdateSavedStateXML()
        {
            xmlWriter.WriteXML();
        }

        public void StoreRoom(int roomNumber) 
        {
            objectTypeData =
                from el in xmlReader.ReadXML()
                where (int)el.Attribute("Room") == roomNumber
                select (string)el.Element("ObjectType");
            objectNameData =
                from el in xmlReader.ReadXML()
                where (int)el.Attribute("Room") == roomNumber
                select (string)el.Element("ObjectName");
            locationData = 
                from el in xmlReader.ReadXML()
                where (int)el.Attribute("Room") == roomNumber
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
                    case "IBlock":
                        IBlock block = ObjectStorage.CreateBlockObject(objectNameList[objectlistPosition]);
                        DoorCalculations(block);
                        CurrentRoomBlocks.Add(block);
                        CurrentRoomBlocks[CurrentRoomBlocks.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))) * Constant.DisplayScaleX, int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)) * Constant.DisplayScaleY) + (Vector2.UnitY * HUDConstants.HUDHeight * Constant.DisplayScaleY);
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IEnemy":
                        CurrentRoomChars.Add(ObjectStorage.CreateCharObject(objectNameList[objectlistPosition]));
                        CurrentRoomChars[CurrentRoomChars.Count -1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))) * Constant.DisplayScaleX, int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)) * Constant.DisplayScaleY) + (Vector2.UnitY * HUDConstants.HUDHeight * Constant.DisplayScaleY);
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "INPC":
                        CurrentRoomChars.Add(ObjectStorage.CreateCharObject(objectNameList[objectlistPosition]));
                        CurrentRoomChars[CurrentRoomChars.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))) * Constant.DisplayScaleX, int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)) * Constant.DisplayScaleY) + (Vector2.UnitY * HUDConstants.HUDHeight * Constant.DisplayScaleY);
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IItem":
                        CurrentRoomItems.Add(ObjectStorage.CreateItemObject(objectNameList[objectlistPosition]));
                        CurrentRoomItems[CurrentRoomItems.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))) * Constant.DisplayScaleX, int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)) * Constant.DisplayScaleY) + (Vector2.UnitY * HUDConstants.HUDHeight * Constant.DisplayScaleY);
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    case "IDoorTrigger":
                        IDoorTrigger doorTrigger = ObjectStorage.CreateDoorTriggerObject(objectNameList[objectlistPosition]);
                        CurrentRoomDoorTriggers.Add(doorTrigger);
                        CurrentRoomDoorTriggers[CurrentRoomDoorTriggers.Count - 1].Position = new Vector2(int.Parse(locationList[locationlistPosition].Substring(0, locationList[locationlistPosition].IndexOf(' '))) * Constant.DisplayScaleX, int.Parse(locationList[locationlistPosition].Substring(locationList[locationlistPosition].IndexOf(' ') + 1)) * Constant.DisplayScaleY) + (Vector2.UnitY * HUDConstants.HUDHeight * Constant.DisplayScaleY);
                        objectlistPosition++;
                        locationlistPosition++;
                        break;
                    default:
                        break;
                }
            }
        }

        private void DoorCalculations(IBlock block)
        {
            switch (block.GameObjectType)
            {
                case Enumerations.GameObjectType.DoorUp:
                    doorDirections.Add(Enumerations.Direction.Up);
                    break;
                case Enumerations.GameObjectType.DoorDown:
                    doorDirections.Add(Enumerations.Direction.Down);
                    break;
                case Enumerations.GameObjectType.DoorLeft:
                    doorDirections.Add(Enumerations.Direction.Left);
                    break;
                case Enumerations.GameObjectType.DoorRight:
                    doorDirections.Add(Enumerations.Direction.Right);
                    break;
                default:
                    break;
            }
        }

        public void storeGridNumber()
        {
            GridNumbers.Add(32);
            GridNumbers.Add(31);
            GridNumbers.Add(33);
            GridNumbers.Add(26);
            GridNumbers.Add(19);
            GridNumbers.Add(20);
            GridNumbers.Add(21);
            GridNumbers.Add(13);
            GridNumbers.Add(14);
            GridNumbers.Add(15);
            GridNumbers.Add(16);
            GridNumbers.Add(10);
            GridNumbers.Add(11);
            GridNumbers.Add(8);
            GridNumbers.Add(2);
            GridNumbers.Add(12);
            GridNumbers.Add(1);
        }

    }
}
