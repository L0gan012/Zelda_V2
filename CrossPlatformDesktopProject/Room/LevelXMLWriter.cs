using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

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


        //Class is just a template for the save state
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
            xmlWriter.WriteStartElement("Dungeon");
            xmlWriter.WriteAttributeString("Level", "1");
            xmlWriter.WriteWhitespace("\n");


            //Counter is the amount of list in the room. I did only three right now as a test
            while (counter <= 3)
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
                    foreach (INPC character in Room.CurrentRoomChars)
                    {
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
                        //Have to get the name of the class
                        xmlWriter.WriteString(character.GetType().Name);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("Location");
                        //Have to get the current position of the obj
                        xmlWriter.WriteString(character.Position.X.ToString() + " " + character.Position.Y.ToString());
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
                    foreach (IItem item in Room.CurrentRoomItems)
                    {
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
                        //Have to get the name of the class
                        xmlWriter.WriteString(item.GetType().Name);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteWhitespace("\n");
                        xmlWriter.WriteWhitespace("\t\t");
                        xmlWriter.WriteStartElement("Location");
                        //Have to get the current position of the obj
                        xmlWriter.WriteString(item.Position.X.ToString() + " " + item.Position.Y.ToString());
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

       /* public void NotSureWhatToCall()
        {
            foreach (IGameObject obj in Room.CurrentRoomBlocks)
            {
                xmlWriter.WriteWhitespace("\t");
                xmlWriter.WriteStartElement("Item");
                xmlWriter.WriteAttributeString("Room", currentRoomNumber.ToString());
                xmlWriter.WriteWhitespace("\n");
                xmlWriter.WriteWhitespace("\t\t");
                xmlWriter.WriteStartElement("ObjectType");
                xmlWriter.WriteString(typeof(obj).GetInterface().Name);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteWhitespace("\n");
                xmlWriter.WriteWhitespace("\t\t");
                xmlWriter.WriteStartElement("ObjectName");
                //Have to get the name of the class
                xmlWriter.WriteString(obj.GetType().Name);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteWhitespace("\n");
                xmlWriter.WriteWhitespace("\t\t");
                xmlWriter.WriteStartElement("Location");
                //Have to get the current position of the obj
                xmlWriter.WriteString(obj.Position.X.ToString() + " " + obj.Position.Y.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteWhitespace("\n");
                xmlWriter.WriteWhitespace("\t");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteWhitespace("\t");
                xmlWriter.WriteWhitespace("\n");
            }
        }*/

    } 
}
