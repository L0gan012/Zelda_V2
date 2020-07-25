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
        private SoundVolumeMixer vol;
        public GameMusicSelectionCommand()
        {
            selectionPosition = new List<Vector2>();
            selectionPosition.Add(new Vector2(200, 70));
            selectionPosition.Add(new Vector2(280, 90));
            selectionPosition.Add(new Vector2(370, 110));
            selectionPosition.Add(new Vector2(400, 130));
            selectionPosition.Add(new Vector2(250, 150));
            selectionPosition.Add(new Vector2(320, 170));
            selectionPosition.Add(new Vector2(670, 190));
            selectionPosition.Add(new Vector2(280, 210));
            selectionPosition.Add(new Vector2(200, 230));
            selectionPosition.Add(new Vector2(570, 250));
            selectionPosition.Add(new Vector2(570, 270));
            selectionPosition.Add(new Vector2(260, 50));
            listCounter = 0;
            vol = new SoundVolumeMixer();
        }

        public void Execute()
        {



            //Returns to the settings state from music state
            if (Keyboard.GetState().IsKeyDown(Keys.B))
            {
                Game1.Instance.State = new StateSetting();
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Space, new GameSettingsCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.Tab, new GameSettingsCommand());
                Game1.Instance.Controllers[0].UpdateCommand(Keys.B, new GameSettingsCommand());

            }


            //Selects Music
            if (Keyboard.GetState().IsKeyDown(Keys.Space)) {
                switch (StateMusicSelection.vector.Y)
                {
                    case 50:
                        SoundManager.Instance.PlayGerudoValleyOOTMusic();
                        break;
                    case 70:
                        SoundManager.Instance.PlayLostWoodsOOTMusic();
                        break;
                    case 90:
                        SoundManager.Instance.PlayPrincessZeldaTimeOOTMusic();
                        break;
                    case 110:
                        SoundManager.Instance.PlayDragonRoostIslandWindWakerMusic();
                        break;
                    case 130:
                        SoundManager.Instance.PlayGreatFairyFountainOOTMusic();
                        break;
                    case 150:
                        SoundManager.Instance.PlayHyruleFieldOOTMusic();
                        break;
                    case 170:
                        SoundManager.Instance.PlayKakarikoVillageOOTMusic();
                        break;
                    case 190:
                        SoundManager.Instance.PlayLoruleCastleALinkBetweenWorldsMusic();
                        break;
                    case 210:
                        SoundManager.Instance.PlayMidnasLamentTwilightPrincessMusic();
                        break;
                    case 230:
                        SoundManager.Instance.PlayWindWakerThemeMusic();
                        break;
                    case 250:
                        SoundManager.Instance.PlayZeddLegendOfZeldaHDMusic();
                        break;
                    case 270:
                        SoundManager.Instance.PlayBOTWThemeMusic();
                        break;
                    default:
                        SoundManager.Instance.PlayDungeonMusic();
                        break;
                }
            }


            if (Keyboard.GetState().IsKeyDown(Keys.PageUp))
            {
                vol.MediaVolUp();
            }

            if (Keyboard.GetState().IsKeyDown(Keys.PageDown))
            {
                vol.MediaVolDown();
            }


            //Mutes music
            if (Keyboard.GetState().IsKeyDown(Keys.M))
            {
                vol.MediaMute();
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
