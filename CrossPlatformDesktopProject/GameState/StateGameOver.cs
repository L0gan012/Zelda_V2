using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateGameOver : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;
        private IGameState state;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        public StateGameOver(IGameState state)
        {
            Game = Game1.Instance;
            this.state = state;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            rect = new Rectangle(0, (int)Constant.HUDHeight, Constant.ScreenWidth, Constant.ScreenHeight);

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
            sb.Draw(background, rect, Color.Black);
            sb.DrawString(font, "Game Over", new Vector2(330, 210), Color.White);
            sb.DrawString(font, "Press Enter to Restart", new Vector2(200, 250), Color.White);

        }

        public void Pause()
        {
        }

        public void UnPause()
        {
            Game.Link = new Link();
            Game.State = state;
        }

        public void Update(IGameObject obj)
        {
        }
    }
}
