using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint2
{
    public class MouseController : IController
    {
        private Dictionary<string, ICommand> commandDictionary;
        private MouseState oldState;

        public MouseController()
        {
            commandDictionary = new Dictionary<string, ICommand>();
        }

        public void RegisterCommand()
        {
            commandDictionary.Add("LeftButton", new LevelBackCommand());
            commandDictionary.Add("RightButton", new LevelFowardCommand());
        }

        public void Update()
        {
            MouseState newState = Mouse.GetState();

            if (newState.LeftButton.Equals(ButtonState.Pressed) && oldState.LeftButton.Equals(ButtonState.Released))
            {
                commandDictionary["LeftButton"].Execute();
            }
            else if (newState.RightButton.Equals(ButtonState.Pressed) && oldState.RightButton.Equals(ButtonState.Released))
            {
                commandDictionary["RightButton"].Execute();
            }
            oldState = newState;
        }
    }
}
