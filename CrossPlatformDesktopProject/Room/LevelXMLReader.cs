using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Sprint2.Room
{
    public class LevelXMLReader
    {

        private StreamReader reader;
        private XmlReader xmlReader;


        public LevelXMLReader()
        {


        }
        public void CheckXMLFile()
        {
            //Opens up files. Prints out error if file is not found.
            try
            {
                reader = new StreamReader("C:\\Users\\Terryls PC\\Source\\Repos\\Zelda_V2\\CrossPlatformDesktopProject\\Room\\LevelLoader.xml");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
