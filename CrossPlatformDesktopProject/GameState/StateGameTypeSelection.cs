using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateGameTypeSelection : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;
        private IGameState state;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        public StateGameTypeSelection(IGameState state)
        {
            Game = Game1.Instance;
            this.state = state;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            rect = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });

            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
        }

        public void Update()
        {
            foreach (IController controller in Game.Controllers)
            {
                controller.Update();
            }
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Begin();
            sb.Draw(background, rect, Color.Black);
            sb.DrawString(font, "Please Select Your Game", new Vector2(150, 100), Color.White);
            sb.DrawString(font, "Classic First Dungeon", new Vector2(170, 200), Color.White);
            sb.DrawString(font, "w - Up || s - Down", new Vector2(200, 400), Color.White);
            sb.DrawString(font, "space - Game Start", new Vector2(200, 500), Color.White);
            sb.End();
        }

        public void Pause()
        {
        }

        public void UnPause()
        {
        }
    }
}
