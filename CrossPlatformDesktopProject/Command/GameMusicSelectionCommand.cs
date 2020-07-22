using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class GameMusicSelectionCommand : ICommand
    {
        private List<Vector2> selectionPosition;
        private int listCounter;
        public GameMusicSelectionCommand()
        {
            selectionPosition = new List<Vector2>();
            selectionPosition.Add(new Vector2(200, 100));
            selectionPosition.Add(new Vector2(280, 150));
            selectionPosition.Add(new Vector2(370, 200));
            selectionPosition.Add(new Vector2(400, 250));
            selectionPosition.Add(new Vector2(250, 300));
            selectionPosition.Add(new Vector2(320, 350));
            selectionPosition.Add(new Vector2(670, 400));
            selectionPosition.Add(new Vector2(280, 450));
            selectionPosition.Add(new Vector2(200, 500));
            selectionPosition.Add(new Vector2(570, 550));
            selectionPosition.Add(new Vector2(260, 50));
            listCounter = 0;
        }

        public void Execute()
        {

            Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new GameSettingsCommand());
            Game1.Instance.Controllers[0].UpdateCommand(Keys.M, new GameMusicSelectionCommand());


            //Selects Music
            if (Keyboard.GetState().IsKeyDown(Keys.Space)) {
                switch (StateMusicSelection.vector.Y)
                {
                    case 50:
                        SoundManager.Instance.PlayGerudoValleyOOTMusic();
                        break;
                    case 100:
                        SoundManager.Instance.PlayLostWoodsOOTMusic();
                        break;
                    case 150:
                        SoundManager.Instance.PlayPrincessZeldaTimeOOTMusic();
                        break;
                    case 200:
                        SoundManager.Instance.PlayDragonRoostIslandWindWakerMusic();
                        break;
                    case 250:
                        SoundManager.Instance.PlayGreatFairyFountainOOTMusic();
                        break;
                    case 300:
                        SoundManager.Instance.PlayHyruleFieldOOTMusic();
                        break;
                    case 350:
                        SoundManager.Instance.PlayKakarikoVillageOOTMusic();
                        break;
                    case 400:
                        SoundManager.Instance.PlayLoruleCastleALinkBetweenWorldsMusic();
                        break;
                    case 450:
                        SoundManager.Instance.PlayMidnasLamentTwilightPrincessMusic();
                        break;
                    case 500:
                        SoundManager.Instance.PlayWindWakerThemeMusic();
                        break;
                    case 550:
                        SoundManager.Instance.PlayZeddLegendOfZeldaHDMusic();
                        break;
                    default:
                        SoundManager.Instance.PlayDungeonMusic();
                        break;
                }
            }


            if (Keyboard.GetState().IsKeyDown(Keys.PageUp))
            {

            }

            if (Keyboard.GetState().IsKeyDown(Keys.PageDown))
            {

            }

            if (Keyboard.GetState().IsKeyDown(Keys.M))
            {
                MediaPlayer.Stop();
            }

            //Changes selection for music wanted
            if (Keyboard.GetState().IsKeyDown(Keys.Tab))
            {
                if(listCounter == selectionPosition.Count) {listCounter = 0;}
                StateMusicSelection.vector = selectionPosition[listCounter];
                listCounter++;
            }


        }
    }
}
