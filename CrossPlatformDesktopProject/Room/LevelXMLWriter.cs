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
        private StreamReader reader;
        private XmlWriter xmlWriter;
       private XmlWriterSettings settings;

        public LevelXMLWriter()
        {
            ApplicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ProjectPath = ApplicationDirectory.Substring(0, ApplicationDirectory.IndexOf("\\bin"));
            settings = new XmlWriterSettings();
            settings.Indent = true;
        }

        public void CheckXMLFile(string roomFile)
        {
            //Opens up files. Prints out error if file is not found.
            try
            {
                reader = new StreamReader(ProjectPath + $"\\Room\\{roomFile}");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

             xmlWriter = XmlWriter.Create(ProjectPath + $"\\Room\\LevelTextFiles\\test.xml");
        }


        public void WriteXML(string roomFile)
        {
            CheckXMLFile(roomFile);

            xmlWriter.WriteStartElement("Dungeon");
            while (reader.EndOfStream)
            {
                xmlWriter.WriteStartElement("item");
                xmlWriter.WriteAttributeString("Room", "1");
                xmlWriter.WriteStartElement("test");
                String nextLine = reader.ReadLine();
                xmlWriter.WriteString(nextLine);
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();

            xmlWriter.Flush();
            xmlWriter.Close();
        }

    } 
}
