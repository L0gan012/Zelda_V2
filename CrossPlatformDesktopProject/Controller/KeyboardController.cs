﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Sprint2.Command;
using System;
using System.Collections.Generic;

namespace Sprint2.Controller
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> commandDictionary;
        private ICommand idle;
        private Game1 game;
        private Keys prev;
        public KeyboardController(Game1 game)
        {
            commandDictionary = new Dictionary<Keys, ICommand>();
            this.game = game;
            prev = Keys.X;
        }

        public void RegisterCommand()
        {
            commandDictionary.Add(Keys.Q, new ExitCommand(game));
            commandDictionary.Add(Keys.R, new ResetCommand(game));

            commandDictionary.Add(Keys.Up, new MoveUpCommand(game));
            commandDictionary.Add(Keys.Down, new MoveDownCommand(game));
            commandDictionary.Add(Keys.Left, new MoveLeftCommand(game));
            commandDictionary.Add(Keys.Right, new MoveRightCommand(game));

            commandDictionary.Add(Keys.W, new MoveUpCommand(game));
            commandDictionary.Add(Keys.S, new MoveDownCommand(game));
            commandDictionary.Add(Keys.A, new MoveLeftCommand(game));
            commandDictionary.Add(Keys.D, new MoveRightCommand(game));

            
            commandDictionary.Add(Keys.D1, new UseItem1Command(game));
            commandDictionary.Add(Keys.D2, new UseItem2Command(game));
            commandDictionary.Add(Keys.D3, new UseItem3Command(game));

            commandDictionary.Add(Keys.Z, new AttackCommand(game));
            commandDictionary.Add(Keys.N, new AttackCommand(game));

            commandDictionary.Add(Keys.I, new ItemFowardCommand(game));
            commandDictionary.Add(Keys.U, new ItemBackCommand(game));

            commandDictionary.Add(Keys.P, new EnemyFowardCommand(game));
            commandDictionary.Add(Keys.O, new EnemyBackCommand(game));

            commandDictionary.Add(Keys.T, new BlockBackCommand(game));
            commandDictionary.Add(Keys.Y, new BlockFowardCommand(game));

            commandDictionary.Add(Keys.E, new DamageCommand(game));

            this.idle = new SetIdleCommand(game);
        }

        public void Update()
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();

            if (pressedKeys.Length == 0)
            {
                idle.Execute();
                prev = Keys.X;
            }
            else
            {
                foreach (Keys key in pressedKeys)
                {
                    if (commandDictionary.ContainsKey(key) && !prev.Equals(key))
                    {
                        commandDictionary[key].Execute();
                        prev = key;
                    }
                }
            }
        }
    }
}
