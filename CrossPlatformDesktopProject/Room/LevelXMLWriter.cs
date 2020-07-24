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

            xmlWriter = XmlWriter.Create(ProjectPath + $"\\Room\\SavedState.xml");
            xmlWriter.WriteStartElement("Dungeon");
            xmlWriter.WriteAttributeString("Level", "1");

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
            int currentRoomNumber = GameObjects.Instance.LevelListPosition;
            xmlWriter.WriteStartElement("Item");
            xmlWriter.WriteAttributeString("Room", currentRoomNumber.ToString());
            switch (counter)
            {
                case 0:
                    foreach (IBlock block in Room.CurrentRoomBlocks)
                    {
                        xmlWriter.WriteStartElement("ObjectType");
                        xmlWriter.WriteString("IBlock");
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteStartElement("ObjectName");
                        //Have to get the name of the class
                        xmlWriter.WriteString(block.GetType().Name);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteStartElement("Location");
                        //Have to get the current position of the obj
                        xmlWriter.WriteString(block.Position.X.ToString() + " " + block.Position.Y.ToString());
                        xmlWriter.WriteEndElement();
                    }
                    counter++;
                    break;
                case 1:

                    counter++;
                    break;
                case 2:

                    counter++;
                    break;
                default:
                    counter++;
                    break;
            }
            xmlWriter.WriteEndElement();

        }

    } 
}
