using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint2
{
    public class MouseController : IController
    {
        private Dictionary<string, ICommand> commandDictionary;
        private Game1 game;
        private MouseState oldState;

        public MouseController(Game1 game)
        {
            commandDictionary = new Dictionary<string, ICommand>();
            this.game = game;
        }

        public void RegisterCommand()
        {
            commandDictionary.Add("LeftButton", new LevelBackCommand(game));
            commandDictionary.Add("RightButton", new LevelFowardCommand(game));
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
