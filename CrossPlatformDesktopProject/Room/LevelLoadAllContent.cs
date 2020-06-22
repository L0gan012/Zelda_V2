using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Room
{
    public class LevelLoadAllContent
    {
        private Game1 game;
        private List<IRoom> rooms;

        public LevelLoadAllContent(Game1 game)
        {
            this.game = game;
            rooms = new List<IRoom>();
        }

        public void LoadAllContent()
        {
            rooms.Add(new LoadIntitalGame(game));
        }
    }
}
