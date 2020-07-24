using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class GameSelectionCommand : ICommand
    {
        private List<Vector2> selectionPosition;
        private int listCounter;
        public GameSelectionCommand()
        {
            selectionPosition = new List<Vector2>();
            selectionPosition.Add(new Vector2(540, 300));
            selectionPosition.Add(new Vector2(600, 190));
            listCounter = 0;
        }

        public void Execute()
        {



            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                switch (StateOptionSelection.vector.X)
                {
                    //Starts Classic Game
                    case 600:
                        Game1.Instance.State = new StateClassicGame();
                        SoundManager.Instance.PlayDungeonMusic();
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new GameSettingsCommand());
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.F, new GameSettingsCommand());
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new NullCommand());
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new NullCommand());
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.PageUp, new GameMusicSelectionCommand());
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.PageDown, new GameMusicSelectionCommand());
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.M, new GameMusicSelectionCommand());
                        break;
                    //Starts Setting
                    case 540:
                        Game1.Instance.State = new StateSetting();
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new GameSettingsCommand());
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new GameSettingsCommand());
                        Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new StartCommand());
                        break;
                    default:
                        break;
                }
            }




            //Changes selection
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                if(listCounter == selectionPosition.Count) {listCounter = 0;}
                StateOptionSelection.vector = selectionPosition[listCounter];
                listCounter++;
            }


        }
    }
}
