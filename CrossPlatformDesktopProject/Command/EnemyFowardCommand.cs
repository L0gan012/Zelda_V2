﻿using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    class EnemyFowardCommand : ICommand
    {
        private Game1 game;

        public EnemyFowardCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (this.game.EnemyListPosition < this.game.ListOfEnemies.Count - 1) 
            { 
                this.game.EnemyListPosition++; 
            }
           
        }
    }
}