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
        private Buttons[] prevPressedButtons;

        public GamePadController()
        {
            commandDictionary = new Dictionary<Buttons, ICommand>();
            prevPressedButtons = new Buttons[0] { };
            oldState = new GamePadState();
        }

        public void RegisterCommand()
        {
            commandDictionary.Add(Buttons.DPadUp, new MoveUpCommand());
            commandDictionary.Add(Buttons.DPadDown, new MoveDownCommand());
            commandDictionary.Add(Buttons.DPadLeft, new MoveLeftCommand());
            commandDictionary.Add(Buttons.DPadRight, new MoveLeftCommand());
        }

        public void UpdateCommand(Keys key, ICommand commandClass)
        {
   
        }

        public void Update()
        {
            GamePadState newState = GamePad.GetState(PlayerIndex.One);
            var capabilities = GamePad.GetCapabilities(PlayerIndex.One);

           /* if (oldState.IsConnected)
            {
                GamePadButtons[] currentPressedButton = new GamePadButtons();
                Buttons[] newPressedButtons = currentPressedButton.Except(prevPressedButtons).ToArray();

                Buttons toExecute = oldState;

                if (currentPressedKeys.Length == 0)
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
            else
            {
                //Please put in a xbox controller
            }
*/
  
        }
    }
}
