using Microsoft.Xna.Framework.Graphics;
using Sprint2.Enemy_NPC;
using Sprint2.Item;
using Sprint2.Room;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Sprint2
{
    public class GameObjects
    {
        private ILink link;
        private StreamReader reader;
        private XmlReader xmlReader;
        public Dictionary<string, string> xmlValues;
        IEnumerable<XElement> getItemTags;

        public List<IItem> Items { get { return Items; } set { Items.Add((IItem)value); } }
        public static List<INPC> Enemies { get { return Enemies; } set { Enemies.Add((IEnemy)value); } }
        private ILink Link { get { return link; } set { link = value; } }
        private ItemLoadAllContent ItemLoader { get; set; }
        private EnemyLoadAllContent EnemyLoader { get; set; }
        private LevelLoadAllContent LevelLoader { get; set; }

        public GameObjects(Game1 game)
        {
            //link = new Link(game); 
            //Items = new List<IItem>();
            //Enemies = new List<INPC>();
            //ItemLoader = new ItemLoadAllContent(game);
            //EnemyLoader = new EnemyLoadAllContent(game);
            //LevelLoader = new LevelLoadAllContent(game);
            xmlValues = new Dictionary<string, string>();

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

        public void ReadXML(Queue<string> addElement)
        {
            CheckXMLFile();
            while (xmlReader.Read())
            {
               if (xmlReader.Name == "Item")
               {
                    XElement el = XElement.ReadFrom(xmlReader) as XElement;
                    addElement.Add(el.Element("ObjectType").Value);
                    addElement.Add(el.Element("ObjectName").Value);

                }

            }
        }

        public void LoadGameObjects()
        {
            //ItemLoader.LoadContent();
            //EnemyLoader.LoadContent();
        }

    }
}
