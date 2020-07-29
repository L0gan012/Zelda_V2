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
            var capabilities = GamePad.GetCapabilities(PlayerIndex.One);
            GamePadButtons buttons = newState.Buttons;

            /*
             *Gamepad is working. I used a ps4 controller but I dont wanted to have to create a new command every if statement
            */


            if (newState.Buttons.A == ButtonState.Pressed) { ICommand test = new AttackCommand(); test.Execute(); }
            if (newState.DPad.Left != oldState.DPad.Left) { ICommand test = new MoveLeftCommand(); test.Execute(); }
            if (newState.DPad.Right != oldState.DPad.Right) { ICommand test = new MoveRightCommand(); test.Execute(); }
            if (newState.DPad.Up != oldState.DPad.Up) { ICommand test = new MoveUpCommand(); test.Execute(); }
            if (newState.DPad.Down != oldState.DPad.Down) { ICommand test = new MoveDownCommand(); test.Execute(); }


        }
    }
}
