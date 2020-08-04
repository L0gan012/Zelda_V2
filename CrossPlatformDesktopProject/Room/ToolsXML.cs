using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;


namespace Sprint2
{
    public class ToolsXML
    {

        private string ApplicationDirectory;
        private string ProjectPath;

        public ToolsXML()
        {
            ApplicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ProjectPath = ApplicationDirectory.Substring(0, ApplicationDirectory.IndexOf("\\bin"));            
        }
        
        public void InitializeGameObjects()
        {
            
            string dungeonLoadFileName = ProjectPath + LevelXMLReader.fileString;
           // string dungeonLoadFileName = ProjectPath + dungeonFilePath;
            string currentDungeonFileName = ProjectPath + "\\Room\\CurrentDungeonState.xml";
            CopyFileOverwrite(dungeonLoadFileName, currentDungeonFileName);
        }
        


        public void SetStageXmlDocument()
        {
            string currentDungeonFileName = ProjectPath + "\\Room\\CurrentDungeonState.xml";
            string stageSettingFileName = ProjectPath + "\\Room\\SetStage.xml";
            CopyFileOverwrite(currentDungeonFileName, stageSettingFileName);

            XmlDocument document = new XmlDocument();
            document.Load(currentDungeonFileName);

 
           XmlNodeList nodes = document.SelectNodes("/Dungeon/Item[@Room='" + GameObjects.Instance.LevelListPosition.ToString() + "']");
           for(int i = nodes.Count - 1; i >= 0; i--)
            {
                nodes[i].ParentNode.RemoveChild(nodes[i]);
            }

            if (File.Exists(currentDungeonFileName))
            {
                File.Delete(currentDungeonFileName);
                document.Save(currentDungeonFileName);
            }
        }


        public void SaveUpdatedRoomXml()
        {
            string currentDungeonFileName = ProjectPath + "\\Room\\CurrentDungeonState.xml";
            string stageUpdateFileName = ProjectPath + "\\Room\\SavedState.xml";

            XmlDocument currentStage = new XmlDocument();
            XmlDocument stageUpdates = new XmlDocument();
            stageUpdates.Load(stageUpdateFileName);
            currentStage.Load(currentDungeonFileName);

            XmlNodeList nodes = stageUpdates.GetElementsByTagName("Item");
            foreach(XmlNode node in nodes)
            {
                XmlNode nodeCopy = currentStage.ImportNode(node, true);
                currentStage.DocumentElement.AppendChild(nodeCopy);
            }
            if (File.Exists(currentDungeonFileName))
            {
                File.Delete(currentDungeonFileName);
                currentStage.Save(currentDungeonFileName);
            }
        }



        public void ReplaceOppositeDoorNodeXML(int roomNumber, Enumerations.DoorType doorType, Enumerations.Direction direction)
        {
            string currentDungeonFileName = ProjectPath + "\\Room\\CurrentDungeonState.xml";
            string oldTrigger;
            string oldDoor;
            string newDoorTrigger;
            string newDoor;
            string stopBlock;
            Vector2 newOverDoorPosition;
            Vector2 newDoorPosition;


            switch (doorType)
            {
                case Enumerations.DoorType.Bombed:
                    switch (direction)
                    {
                        case Enumerations.Direction.Left:
                            oldTrigger = "BlockLeftOverWall";
                            oldDoor = "BlockUpBreakableWall";
                            newDoorTrigger = "BlockUpOverBombed";
                            newDoor = "BlockUpBombedOpening";
                            stopBlock = "NoStopBlock";
                            newOverDoorPosition = Constant.LeftOverBombedPosition;
                            newDoorPosition = Constant.LeftDoorPositionNative;
                            break;
                        case Enumerations.Direction.Right:
                            oldTrigger = "BlockRightOverWall";
                            oldDoor = "BlockRightBreakableWall";
                            newDoorTrigger = "BlockRightOverBombed";
                            newDoor = "BlockRightBombedOpening";
                            stopBlock = "NoStopBlock";
                            newOverDoorPosition = Constant.RightOverBombedPositionNative;
                            newDoorPosition = Constant.RightDoorPositionNative;
                            break;
                        case Enumerations.Direction.Up:
                            oldTrigger = "BlockUpOverWall";
                            oldDoor = "BlockUpBreakableWall";
                            newDoorTrigger = "BlockUpOverBombed";
                            newDoor = "BlockUpBombedOpening";
                            stopBlock = "NoStopBlock";
                            newOverDoorPosition = Constant.UpOverBombedPositionNative;
                            newDoorPosition = Constant.UpDoorPositionNative;
                            break;
                        case Enumerations.Direction.Down:
                            oldTrigger = "BlockDownOverWall";
                            oldDoor = "BlockDownBreakableWall";
                            newDoorTrigger = "BlockDownOverBombed";
                            newDoor = "BlockDownBombedDoor";
                            stopBlock = "NoStopBlock";
                            newOverDoorPosition = Constant.DownOverBombedPositionNative;
                            newDoorPosition = Constant.DownDoorPositionNative;
                            break;
                        default:
                            oldTrigger = "NoOldTrigger";
                            oldDoor = "NoOldDoor";
                            newDoorTrigger = "NoNewDoorTrigger";
                            newDoor = "NoNewDoor";
                            stopBlock = "NoStopBlock";
                            newOverDoorPosition = Constant.DownOverBombedPositionNative;
                            newDoorPosition = Constant.DownDoorPositionNative;
                            break;
                    }
                    break;
                case Enumerations.DoorType.Locked:
                    switch (direction)
                    {
                        case Enumerations.Direction.Left:
                            oldTrigger = "BlockLeftOverDoor";
                            oldDoor = "BlockLeftLockedDoor";
                            newDoorTrigger = "BlockLeftOverDoor";
                            newDoor = "BlockLeftOpenDoor";
                            stopBlock = "BlockLeftLockedDoorStop";
                            newOverDoorPosition = Constant.LeftOverDoorPositionNative;
                            newDoorPosition = Constant.LeftDoorPositionNative;
                            break;
                        case Enumerations.Direction.Right:
                            oldTrigger = "BlockRightOverDoor";
                            oldDoor = "BlockRightLockedDoor";
                            newDoorTrigger = "BlockRightOverDoor";
                            newDoor = "BlockRightOpenDoor";
                            stopBlock = "BlockRightLockedDoorStop";
                            newOverDoorPosition = Constant.RightOverDoorPositionNative;
                            newDoorPosition = Constant.RightDoorPositionNative;
                            break;
                        case Enumerations.Direction.Up:
                            oldTrigger = "BlockUpOverDoor";
                            oldDoor = "BlockUpLockedDoor";
                            newDoorTrigger = "BlockUpOverDoor";
                            newDoor = "BlockUpOpenDoor";
                            stopBlock = "BlockUpLockedDoorStop";
                            newOverDoorPosition = Constant.UpOverDoorPositionNative;
                            newDoorPosition = Constant.UpDoorPositionNative;
                            break;
                        case Enumerations.Direction.Down:
                            oldTrigger = "BlockDownOverDoor";
                            oldDoor = "BlockDownLockedDoor";
                            newDoorTrigger = "BlockDownOverDoor";
                            newDoor = "BlockDownOpenDoor";
                            stopBlock = "BlockDownLockedDoorStop";
                            newOverDoorPosition = Constant.DownOverDoorPositionNative;
                            newDoorPosition = Constant.DownDoorPositionNative;
                            break;
                        default:
                            oldTrigger = "NoOldTrigger";
                            oldDoor = "NoOldDoor";
                            newDoorTrigger = "NoNewDoorTrigger";
                            newDoor = "NoNewDoor";
                            stopBlock = "NoStopBlock";
                            newOverDoorPosition = Constant.DownOverBombedPositionNative;
                            newDoorPosition = Constant.DownDoorPositionNative;
                            break;
                    }
                    break;
                default:
                    oldTrigger = "NoOldTrigger";
                    oldDoor = "NoOldDoor";
                    newDoorTrigger = "NoNewDoorTrigger";
                    newDoor = "NoNewDoor";
                    stopBlock = "NoStopBlock";
                    newOverDoorPosition = Constant.DownOverBombedPositionNative;
                    newDoorPosition = Constant.DownDoorPositionNative;
                    break;
            }

            XmlDocument document = new XmlDocument();
            document.Load(currentDungeonFileName);
            XmlNodeList nodes = document.SelectNodes("/Dungeon/Item[@Room='" + roomNumber.ToString() + "']");
            for (int i = nodes.Count - 1; i >= 0; i--)
            {
                for(int j = nodes[i].ChildNodes.Count - 1; j >= 0; j--)
                if (nodes[i].ChildNodes[j].InnerText == oldTrigger || nodes[i].ChildNodes[j].InnerText == oldDoor || nodes[i].ChildNodes[j].InnerText == stopBlock)
                {
                    nodes[i].ParentNode.RemoveChild(nodes[i]);
                }

            }



            XmlElement newDoorNode = document.CreateElement("Item");
            newDoorNode.SetAttribute("Room", roomNumber.ToString());
            XmlElement newDoorNodeObjectType = document.CreateElement("ObjectType");
            newDoorNodeObjectType.InnerText = "IBlock";
            XmlElement newDoorNodeObjectName = document.CreateElement("ObjectName");
            newDoorNodeObjectName.InnerText = newDoor;
            XmlElement newDoorNodeLocation = document.CreateElement("Location");
            newDoorNodeLocation.InnerText = newDoorPosition.X.ToString() + " " + newDoorPosition.Y.ToString();
            newDoorNode.AppendChild(newDoorNodeObjectType);
            newDoorNode.AppendChild(newDoorNodeObjectName);
            newDoorNode.AppendChild(newDoorNodeLocation);
            document.DocumentElement.AppendChild(newDoorNode);


            XmlElement newOverDoorNode = document.CreateElement("Item");
            newOverDoorNode.SetAttribute("Room", roomNumber.ToString());
            XmlElement newOverDoorNodeObjectType = document.CreateElement("ObjectType");
            newOverDoorNodeObjectType.InnerText = "IDoorTrigger";
            XmlElement newOverDoorNodeObjectName = document.CreateElement("ObjectName");
            newOverDoorNodeObjectName.InnerText = newDoorTrigger;
            XmlElement newOverDoorNodeLocation = document.CreateElement("Location");
            newOverDoorNodeLocation.InnerText = newOverDoorPosition.X.ToString() + " " + newOverDoorPosition.Y.ToString();
            newOverDoorNode.AppendChild(newOverDoorNodeObjectType);
            newOverDoorNode.AppendChild(newOverDoorNodeObjectName);
            newOverDoorNode.AppendChild(newOverDoorNodeLocation);
            document.DocumentElement.AppendChild(newOverDoorNode);
            if (File.Exists(currentDungeonFileName))
            {
                File.Delete(currentDungeonFileName);
                document.Save(currentDungeonFileName);
            }

        }


        public void OpenAllSealedDoors(List<IBlock> currentRoomBlocks)
        {
            IBlock newDoor;
            if (currentRoomBlocks.Count != 0)
            {

                for (int blockCount = 0; blockCount < currentRoomBlocks.Count; blockCount++)
                {
                    if (currentRoomBlocks[blockCount].GameObjectType == Enumerations.GameObjectType.DownSealStop)
                    {
                        currentRoomBlocks[blockCount].IsDestructable = true;
                        newDoor = new BlockDownOpenDoor();
                        newDoor.Position = Constant.DownDoorPosition;
                        foreach (IBlock blockDoor in Room.CurrentRoomBlocks)
                        {
                            if (blockDoor.GameObjectType == Enumerations.GameObjectType.DoorDown)
                            {
                                blockDoor.IsDestructable = true;
                            }
                        }
                        Room.CurrentRoomBlocks.Add(newDoor);
                        SoundManager.Instance.PlayDoorStateChange();
                    }
                    else if (currentRoomBlocks[blockCount].GameObjectType == Enumerations.GameObjectType.LeftSealStop)
                    {
                        currentRoomBlocks[blockCount].IsDestructable = true;
                        newDoor = new BlockLeftOpenDoor();
                        newDoor.Position = Constant.LeftDoorPosition;
                        foreach (IBlock blockDoor in Room.CurrentRoomBlocks)
                        {
                            if (blockDoor.GameObjectType == Enumerations.GameObjectType.DoorLeft)
                            {
                                blockDoor.IsDestructable = true;
                            }
                        }
                        Room.CurrentRoomBlocks.Add(newDoor);
                        SoundManager.Instance.PlayDoorStateChange();
                    }
                    else if (currentRoomBlocks[blockCount].GameObjectType == Enumerations.GameObjectType.RightSealStop)
                    {
                        currentRoomBlocks[blockCount].IsDestructable = true;
                        newDoor = new BlockRightOpenDoor();
                        newDoor.Position = Constant.RightDoorPosition;
                        foreach (IBlock blockDoor in Room.CurrentRoomBlocks)
                        {
                            if (blockDoor.GameObjectType == Enumerations.GameObjectType.DoorRight)
                            {
                                blockDoor.IsDestructable = true;
                            }
                        }
                        Room.CurrentRoomBlocks.Add(newDoor);
                        SoundManager.Instance.PlayDoorStateChange();
                    }
                    else if (currentRoomBlocks[blockCount].GameObjectType == Enumerations.GameObjectType.UpSealStop)
                    {
                        currentRoomBlocks[blockCount].IsDestructable = true;
                        newDoor = new BlockUpOpenDoor();
                        newDoor.Position = Constant.UpDoorPosition;
                        foreach (IBlock blockDoor in Room.CurrentRoomBlocks)
                        {
                            if (blockDoor.GameObjectType == Enumerations.GameObjectType.DoorUp)
                            {
                                blockDoor.IsDestructable = true;
                            }
                        }
                        Room.CurrentRoomBlocks.Add(newDoor);
                        SoundManager.Instance.PlayDoorStateChange();
                    }
                }
            }
        }
        


        private static void CopyFileOverwrite(string sourceFile, string destinationFile)
        {
            File.Copy(sourceFile, destinationFile, true);
        }
    }
}
