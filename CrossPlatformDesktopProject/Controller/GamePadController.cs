using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
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
            commandDictionary.Add(Buttons.A, new AttackCommand());
            commandDictionary.Add(Buttons.Start, new PauseCommand());
            commandDictionary.Add(Buttons.LeftStick, new SettingsCycleOptionCommand());
            commandDictionary.Add(Buttons.RightStick, new GoBackCommand());




        }

        public void UpdateCommand(Keys key, ICommand commandClass)
        {

        }

        public void Update()
        {
            GamePadState newState = GamePad.GetState(PlayerIndex.One);

            /*
             *Gamepad is working. I used a ps4 controller but I dont wanted to have to create a new command every if statement
            */





            if (newState.Buttons.A == ButtonState.Pressed) { commandDictionary[Buttons.A].Execute(); }
            if (newState.Buttons.Start == ButtonState.Pressed) { commandDictionary[Buttons.Start].Execute(); }

            if (newState.IsButtonDown(Buttons.DPadLeft))
            {
                commandDictionary[Buttons.DPadLeft].Execute();
            }
            else if (newState.IsButtonDown(Buttons.DPadRight))
            {
                commandDictionary[Buttons.DPadRight].Execute();
            }
            else if (newState.IsButtonDown(Buttons.DPadUp))
            {
                commandDictionary[Buttons.DPadUp].Execute();
            }
            else if (newState.IsButtonDown(Buttons.DPadDown))
            {
                commandDictionary[Buttons.DPadDown].Execute();
            }
            else if (newState.IsButtonUp(Buttons.DPadLeft) || 
                newState.IsButtonUp(Buttons.DPadRight) || 
                newState.IsButtonUp(Buttons.DPadUp)|| newState.IsButtonUp(Buttons.DPadDown))
            {
                Game1.Instance.Link.SetIdle();
            }


        }
    }
}
