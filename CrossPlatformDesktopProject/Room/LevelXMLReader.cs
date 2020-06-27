using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Sprint2.Room
{
    public class LevelXMLReader
    {
        private string ApplicationDirectory;
        private string ProjectPath;
        private StreamReader reader;
        private XmlReader xmlReader;



        public LevelXMLReader()
        {
            ApplicationDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ProjectPath = ApplicationDirectory.Substring(0, ApplicationDirectory.IndexOf("\\bin"));
        }
        public void CheckXMLFile()
        {

            //Opens up files. Prints out error if file is not found.
            try
            {
                reader = new StreamReader(ProjectPath + "\\Room\\LevelLoader.xml");

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
            CheckXMLFile();
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "Item")
                {
                    XElement el = XElement.ReadFrom(xmlReader) as XElement;
                    if (el != null)
                        yield return el;  
                }

            }


        }


    } 
}
