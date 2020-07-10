using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> commandDictionary;
        private Keys prev;
        private Keys[] prevPressedKeys;

        public KeyboardController()
        {
            commandDictionary = new Dictionary<Keys, ICommand>();
            prev = Keys.None;
            prevPressedKeys = new Keys[0] { };
        }

        public void RegisterCommand()
        {
            commandDictionary.Add(Keys.Q, new ExitCommand());
            commandDictionary.Add(Keys.R, new ResetCommand());

            commandDictionary.Add(Keys.None, new SetIdleCommand());

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
        }

        public void Update()
        {
            Keys[] currentPressedKeys = Keyboard.GetState().GetPressedKeys();
            Keys[] newPressedKeys = currentPressedKeys.Except(prevPressedKeys).ToArray();
            Keys[] samePressedKeys = currentPressedKeys.Intersect(prevPressedKeys).ToArray();

            Keys toExecute = prev;

            if(currentPressedKeys.Length == 0)
            {
                prev = Keys.None;
            }
            else
            {
                if(newPressedKeys.Length == 1)
                {
                    toExecute = newPressedKeys[0];
                    prev = newPressedKeys[0];
                }
                else if (samePressedKeys.Length == 1)
                {
                    toExecute = samePressedKeys[0];
                }
            }

            if (commandDictionary.ContainsKey(toExecute))
            {
                commandDictionary[toExecute].Execute();
            }

            prevPressedKeys = currentPressedKeys;
        }
    }
}
