using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    class ItemBackCommand : ICommand
    {
        private Game1 game;

        public ItemBackCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (this.game.ItemListPosition > 0) 
            { 
                this.game.ItemListPosition--; 
            }
           
        }
    }
}