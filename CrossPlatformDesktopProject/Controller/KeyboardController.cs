using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint2
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> commandDictionary;
        private ICommand idle;
        private Keys prev;

        public KeyboardController()
        {
            commandDictionary = new Dictionary<Keys, ICommand>();
            prev = Keys.X;
        }

        public void RegisterCommand()
        {
            commandDictionary.Add(Keys.Q, new ExitCommand());
            commandDictionary.Add(Keys.R, new ResetCommand());

            commandDictionary.Add(Keys.Up, new MoveUpCommand());
            commandDictionary.Add(Keys.Down, new MoveDownCommand());
            commandDictionary.Add(Keys.Left, new MoveLeftCommand());
            commandDictionary.Add(Keys.Right, new MoveRightCommand());

            commandDictionary.Add(Keys.W, new MoveUpCommand());
            commandDictionary.Add(Keys.S, new MoveDownCommand());
            commandDictionary.Add(Keys.A, new MoveLeftCommand());
            commandDictionary.Add(Keys.D, new MoveRightCommand());


            commandDictionary.Add(Keys.D1, new UseItem1Command());
            commandDictionary.Add(Keys.D2, new UseItem2Command());
            commandDictionary.Add(Keys.D3, new UseItem3Command());
            commandDictionary.Add(Keys.D4, new UseItem4Command());
            commandDictionary.Add(Keys.D5, new UseItem5Command());
            commandDictionary.Add(Keys.D6, new UseItem6Command());
            commandDictionary.Add(Keys.D7, new UseItem7Command());

            commandDictionary.Add(Keys.Z, new AttackCommand());
            commandDictionary.Add(Keys.N, new AttackCommand());

            commandDictionary.Add(Keys.I, new LevelFowardCommand());
            commandDictionary.Add(Keys.U, new LevelBackCommand());

            commandDictionary.Add(Keys.E, new DamageCommand());


            //Debugging Collision
            commandDictionary.Add(Keys.F1, new DebugDrawHitBoxesCommand());


            idle = new SetIdleCommand();
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
