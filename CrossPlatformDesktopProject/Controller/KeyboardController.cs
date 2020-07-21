using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2
{
    class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> commandDictionary { get; set; }
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

            commandDictionary.Add(Keys.Z, new UseSecondaryItemCommand());

            commandDictionary.Add(Keys.X, new AttackCommand());
            commandDictionary.Add(Keys.N, new AttackCommand());

            commandDictionary.Add(Keys.I, new LevelFowardCommand());
            commandDictionary.Add(Keys.U, new LevelBackCommand());

            commandDictionary.Add(Keys.E, new DamageCommand());

            commandDictionary.Add(Keys.Enter, new PauseCommand());
            commandDictionary.Add(Keys.C, new SelectItemForwardCommand());

            commandDictionary.Add(Keys.Space, new StartCommand());


            //Debugging Collision
            commandDictionary.Add(Keys.F1, new DebugDrawHitBoxesCommand());
        }


        public void UpdateCommand(Keys key, ICommand commandClass)
        {
            if (commandDictionary.ContainsKey(key)) { commandDictionary[key] = commandClass; }
        }


        public void Update()
        {
            Keys[] currentPressedKeys = Keyboard.GetState().GetPressedKeys();
            Keys[] newPressedKeys = currentPressedKeys.Except(prevPressedKeys).ToArray();

            Keys toExecute = prev;

            if(currentPressedKeys.Length == 0)
            {
                toExecute = Keys.None;
            }
            else if (newPressedKeys.Length > 0)
            {
                toExecute = newPressedKeys[0];
            }

            if (toExecute != prev && commandDictionary.ContainsKey(toExecute))
            {
                commandDictionary[toExecute].Execute();
            }

            prev = toExecute;
            prevPressedKeys = currentPressedKeys;
        }
    }
}
