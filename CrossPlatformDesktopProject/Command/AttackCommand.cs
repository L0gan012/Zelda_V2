﻿using Sprint2.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Command
{
    class AttackCommand : ICommand
    {
        private Game1 game;

        public AttackCommand(Game1 game)
        {
            this.game = game;
        }

        public void Execute()
        {
            this.game.Link.Attack();
        }
    }
}