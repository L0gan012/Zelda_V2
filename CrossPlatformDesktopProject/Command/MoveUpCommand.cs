using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    class MoveUpCommand : ICommand
    {
        private Game1 game;
 
        public MoveUpCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        { 
            this.game.Link.MoveUp();
        }
    }
}
