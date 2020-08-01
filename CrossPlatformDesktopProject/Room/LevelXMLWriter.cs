using System;
using System.Xml;

namespace Sprint2
{
    public class LevelXMLWriter
    {
        private string ApplicationDirectory;
        private string ProjectPath;
        private XmlWriter xmlWriter;
        private XmlWriterSettings settings;
        private int counter;
        int currentRoomNumber;

        public LevelXMLWriter()
        {
            ApplicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ProjectPath = ApplicationDirectory.Substring(0, ApplicationDirectory.IndexOf("\\bin"));
            settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\n";
            counter = 0;

        }

        public void WriteXML()
        {
            currentRoomNumber = GameObjects.Instance.LevelListPosition;
            xmlWriter = XmlWriter.Create(ProjectPath + "\\Room\\SavedState.xml");
            xmlWriter.WriteWhitespace("\n");
            xmlWriter.WriteStartElement("Dungeon");
            xmlWriter.WriteAttributeString("Level", "1");
            xmlWriter.WriteWhitespace("\n");

            while (counter <= 4)
            {
                XMLUpdater();

            }
            xmlWriter.WriteEndElement();
            xmlWriter.Flush();
            xmlWriter.Close();
        }


        public void XMLUpdater()
        {

            switch (counter)
            {          
                case 0:
                    foreach (IBlock block in Room.CurrentRoomBlocks)
                    {
                        int x = (int)(block.Position.X / Constant.DisplayScaleX);
                        int y = (int)(block.Position.Y / Constant.DisplayScaleY - HUDConstants.HUDHeight);
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteStartElement("Item");
                        xmlWriter.WriteAttributeString("Room", currentRoomNumber.ToString());
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("ObjectType");
                        xmlWriter.WriteString("IBlock");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("ObjectName");
                        xmlWriter.WriteString(block.GetType().Name);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("Location");
                        xmlWriter.WriteString(x.ToString() + " " + y.ToString());
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteWhitespace("\n");
                    }
                    counter++;
                    break;
                case 1:
                    foreach (IDoorTrigger doorTrigger in Room.CurrentRoomDoorTriggers)
                    {
                        int x = (int)(doorTrigger.Position.X / Constant.DisplayScaleX);
                        int y = (int)(doorTrigger.Position.Y / Constant.DisplayScaleY - HUDConstants.HUDHeight);
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteStartElement("Item");
                        xmlWriter.WriteAttributeString("Room", currentRoomNumber.ToString());
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("ObjectType");
                        xmlWriter.WriteString("IDoorTrigger");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("ObjectName");
                        xmlWriter.WriteString(doorTrigger.GetType().Name);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("Location");
                        xmlWriter.WriteString(x.ToString() + " " + y.ToString());
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteWhitespace("\n");
                    }
                    counter++;
                    break;
                case 2:
                    foreach (IItem item in Room.CurrentRoomItems)
                    {
                        int x = (int)(item.Position.X / Constant.DisplayScaleX);
                        int y = (int)(item.Position.Y / Constant.DisplayScaleY - HUDConstants.HUDHeight);
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteStartElement("Item");
                        xmlWriter.WriteAttributeString("Room", currentRoomNumber.ToString());
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("ObjectType");
                        xmlWriter.WriteString("IItem");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("ObjectName");
                        xmlWriter.WriteString(item.GetType().Name);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("Location");
                        xmlWriter.WriteString(x.ToString() + " " + y.ToString());
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteWhitespace("\n");
                    }
                    counter++;
                    break;
                case 3:
                    foreach (INPC character in Room.CurrentRoomChars)
                    {
                        int x = (int)(character.Position.X / Constant.DisplayScaleX);
                        int y = (int)(character.Position.Y / Constant.DisplayScaleY - HUDConstants.HUDHeight);
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteStartElement("Item");
                        xmlWriter.WriteAttributeString("Room", currentRoomNumber.ToString());
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("ObjectType");
                        xmlWriter.WriteString("IEnemy");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("ObjectName");
                        xmlWriter.WriteString(character.GetType().Name);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("Location");
                        xmlWriter.WriteString(x.ToString() + " " + y.ToString());
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\t");
                        xmlWriter.WriteWhitespace("\n");
                    }
                    counter++;
                    break;

                default:
                    counter++;
                    break;
            }
        }
    } 
}
