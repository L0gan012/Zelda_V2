using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;

namespace Sprint2
{
    public class GamePadController : IController
    {
        private Dictionary<Buttons, ICommand> commandDictionary;
        private GamePadState oldState;
  
        public GamePadController()
        {
            commandDictionary = new Dictionary<Buttons, ICommand>();
            oldState = new GamePadState();
        }

        public void RegisterCommand()
        {
            commandDictionary.Add(Buttons.DPadUp, new MoveUpCommand());
            commandDictionary.Add(Buttons.DPadDown, new MoveDownCommand());
            commandDictionary.Add(Buttons.DPadLeft, new MoveLeftCommand());
            commandDictionary.Add(Buttons.DPadRight, new MoveRightCommand());
            commandDictionary.Add(Buttons.LeftThumbstickUp, new MoveUpCommand());
            commandDictionary.Add(Buttons.LeftThumbstickDown, new MoveDownCommand());
            commandDictionary.Add(Buttons.LeftThumbstickLeft, new MoveLeftCommand());
            commandDictionary.Add(Buttons.LeftThumbstickRight, new MoveRightCommand());


        }

        public void UpdateCommand(Keys key, ICommand commandClass)
        {
   
        }

        public void Update()
        {
            GamePadState newState = GamePad.GetState(PlayerIndex.One);
            var capabilities = GamePad.GetCapabilities(PlayerIndex.One);

            if (oldState != newState)
            {
                if(newState.Buttons.LeftStick == ButtonState.Pressed) { commandDictionary[0].Execute(); }
            }


        }
    }
}
