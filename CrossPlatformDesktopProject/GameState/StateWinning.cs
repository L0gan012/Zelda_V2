using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateWinning : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;
        private IGameState state;

        private Texture2D background;
        private SpriteFont font;

        public StateWinning(IGameState state)
        {
            Game = Game1.Instance;
            this.state = state;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

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
            sb.Draw(background, new Rectangle(0, (int)(HUDConstants.HUDHeight * Constant.DisplayScaleY), (int)(Constant.OriginalNesWidth * Constant.DisplayScaleX), (int)(Constant.OriginalNesHeight * Constant.DisplayScaleY)), Color.Black);
            sb.DrawString(font, "You Got The Triforce Piece!", new Vector2(57 * Constant.DisplayScaleX, 70 * Constant.DisplayScaleX), Color.White);
            sb.DrawString(font, "Press Enter to Restart", new Vector2(67 * Constant.DisplayScaleX, 83 * Constant.DisplayScaleX), Color.White);

            Game.Link.Draw(sb);

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
