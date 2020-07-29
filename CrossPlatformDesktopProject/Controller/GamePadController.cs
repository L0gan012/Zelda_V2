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
            oldState = GamePad.GetState(PlayerIndex.One);
        }

        public void RegisterCommand()
        {
            commandDictionary.Add(Buttons.DPadUp, new MoveUpCommand());
            commandDictionary.Add(Buttons.DPadDown, new MoveDownCommand());
            commandDictionary.Add(Buttons.DPadLeft, new MoveLeftCommand());
            commandDictionary.Add(Buttons.DPadRight, new MoveRightCommand());
            commandDictionary.Add(Buttons.A, new AttackCommand());
            commandDictionary.Add(Buttons.X, new UseSecondaryItemCommand());
            commandDictionary.Add(Buttons.B, new GoBackCommand());
            commandDictionary.Add(Buttons.Y, new SettingsSelectCommand());
            commandDictionary.Add(Buttons.Start, new PauseCommand());
            commandDictionary.Add(Buttons.LeftStick, new OpenSettingsFromPausedCommand());
            commandDictionary.Add(Buttons.RightStick, new SettingsCycleOptionCommand());

            commandDictionary.Add(Buttons.LeftTrigger, new SelectItemForwardCommand());
        }

        public void UpdateCommand(Keys key, ICommand commandClass)
        {

        }

        public void DeregisterCommands()
        {
            commandDictionary.Clear();
        }
        
        public void Update()
        {
            GamePadState newState = GamePad.GetState(PlayerIndex.One);

       
            if (newState.Buttons.A.Equals(ButtonState.Pressed) && oldState.Buttons.A.Equals(ButtonState.Released)) { 
                commandDictionary[Buttons.A].Execute(); 
            }
            if (newState.Buttons.X.Equals(ButtonState.Pressed) && oldState.Buttons.X.Equals(ButtonState.Released)) { 
                commandDictionary[Buttons.X].Execute(); 
            }
            if (newState.Buttons.B.Equals(ButtonState.Pressed) && oldState.Buttons.B.Equals(ButtonState.Released))
            {
                commandDictionary[Buttons.B].Execute();
            }

            if (newState.Buttons.Y.Equals(ButtonState.Pressed) && oldState.Buttons.Y.Equals(ButtonState.Released))
            {
                commandDictionary[Buttons.Y].Execute();
            }

            if (newState.Buttons.LeftStick.Equals(ButtonState.Pressed) && oldState.Buttons.LeftStick.Equals(ButtonState.Released))
            {
                commandDictionary[Buttons.LeftStick].Execute();
            }

            if (newState.Buttons.RightStick.Equals(ButtonState.Pressed) && oldState.Buttons.RightStick.Equals(ButtonState.Released))
            {
                commandDictionary[Buttons.RightStick].Execute();
            }


            if (newState.Buttons.Start.Equals(ButtonState.Pressed) && oldState.Buttons.Start.Equals(ButtonState.Released)) { 
                commandDictionary[Buttons.Start].Execute(); 
            }

            if (newState.IsButtonDown(Buttons.LeftTrigger) && oldState.IsButtonUp(Buttons.LeftTrigger)) 
            { 
                commandDictionary[Buttons.LeftTrigger].Execute();
            }
            

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

            oldState = newState;

        }
    }
}
