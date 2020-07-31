using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateSettings : IGameState
    {
        public ISettingsPage SettingsPage { get; set; }
        public Stack<ISettingsPage> PreviousPages { get; set; }

        private SpriteFont font;
        public IGameState PreviousState { get; private set; }

        public StateSettings(IGameState previous)
        {
            PreviousState = previous;
            SettingsPage = new StartPage();
            PreviousPages = new Stack<ISettingsPage>();
            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
            /*
             * Music keeps updating everytime this state starts. 
             * Only wanted this music to play at the beginning of the game
             * This line interrupts the music that is already playing if user changes.
             */
            //SoundManager.Instance.PlayIntroMusic();
        }

        public void Update()
        {
 

            for(int x = 0; x < Game1.Instance.Controllers.Count; x++)
            {
                Game1.Instance.Controllers[x].Update();
            }


            SettingsPage.Update();
        }

        public void Draw(SpriteBatch sb)
        {
            SettingsPage.Draw(sb, font);
        }

        public void Pause()
        {

        }

        public void UnPause()
        {
            Game1.Instance.State = PreviousState;
        }

        public void Update(IGameObject obj)
        {
        }
    }
}
