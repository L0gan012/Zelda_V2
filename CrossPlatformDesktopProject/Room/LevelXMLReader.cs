using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Sprint2
{
    public class LevelXMLReader
    {
        private string ApplicationDirectory;
        private string ProjectPath;
        private StreamReader reader;
        private XmlReader xmlReader;
        private List<int> discoveredRoom;
        private string currentDungeonStateString;

        public static string fileString { get; set; }

        public LevelXMLReader()
        {
            ApplicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ProjectPath = ApplicationDirectory.Substring(0, ApplicationDirectory.IndexOf("\\bin"));
            currentDungeonStateString = "\\Room\\CurrentDungeonState.xml";
            discoveredRoom = new List<int>();
        }

        public void CheckFile()
        {
            //Opens up files. Prints out error if file is not found.
            try
            {
                reader = new StreamReader(ProjectPath + currentDungeonStateString);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }

             xmlReader = XmlReader.Create(reader);
        }


        public IEnumerable<XElement> ReadXML()
        {

            CheckFile();
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "Item")
                {
                    XElement el = XElement.ReadFrom(xmlReader) as XElement;
                    if (el != null)
                        yield return el;  
                }
            }
            
            xmlReader.Close();
            reader.Close();
        }
    } 
}
