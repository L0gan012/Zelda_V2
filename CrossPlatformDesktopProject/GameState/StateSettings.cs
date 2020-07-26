using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateSettings : IGameState
    {
        public Game1 Game { get; set; }

        public ISettingsPage SettingsPage { get; set; }
        public ISettingsPage PreviousPage { get; set; }

        private SpriteFont font;

        public StateSettings()
        {
            Game = Game1.Instance;
            SettingsPage = new StartPage();
            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
        }

        public void Update()
        {
            foreach (IController controller in Game.Controllers)
            {
                controller.Update();
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

        }

        public void Update(IGameObject obj)
        {
        }
    }
}
