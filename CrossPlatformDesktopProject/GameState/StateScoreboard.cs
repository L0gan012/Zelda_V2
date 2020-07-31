using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    class StateScoreboard : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;
        private IGameState state;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        private int hightestScore;
        private int currentScore;

        public StateScoreboard(IGameState state, int highest, int current)
        {
            Game = Game1.Instance;
            this.state = state;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });
            
            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");

            hightestScore = highest;
            currentScore = current;
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
            sb.Draw(background, new Rectangle(0, (int)(HUDConstants.HUDHeight * Constant.DisplayScaleY), (int)(Constant.OriginalNesWidth * Constant.DisplayScaleX), (int)(Constant.OriginalNesHeight * Constant.DisplayScaleY)), Color.Black);
            sb.DrawString(font, "Hightest Score: ", new Vector2(80 * Constant.DisplayScaleX, 70 * Constant.DisplayScaleY), Color.White);
            sb.DrawString(font, hightestScore.ToString(), new Vector2(180 * Constant.DisplayScaleX, 70 * Constant.DisplayScaleY), Color.White);
            sb.DrawString(font, "Current Score: ", new Vector2(80 * Constant.DisplayScaleX, 83 * Constant.DisplayScaleY), Color.White);
            sb.DrawString(font, currentScore.ToString(), new Vector2(170 * Constant.DisplayScaleX, 83 * Constant.DisplayScaleY), Color.White);

            sb.DrawString(font, "Press Enter to Return", new Vector2(67 * Constant.DisplayScaleX, 96 * Constant.DisplayScaleY), Color.White);

        }

        public void Pause()
        {
        }

        public void UnPause()
        {
            Game.State = state;
        }

        public void Update(IGameObject obj)
        {
        }
    }
}
