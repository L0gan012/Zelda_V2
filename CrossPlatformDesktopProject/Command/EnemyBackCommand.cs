﻿using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    class EnemyBackCommand : ICommand
    {
        private Game1 game;

        public EnemyBackCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (this.game.EnemyListPosition > 0) 
            { 
                this.game.EnemyListPosition--; 
            }
           
        }
    }
}