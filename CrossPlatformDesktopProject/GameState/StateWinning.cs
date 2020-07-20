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

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        public StateWinning(IGameState state)
        {
            Game = Game1.Instance;
            this.state = state;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            rect = new Rectangle(0, Constant.HUDHeight, Constant.ScreenWidth, Constant.ScreenHeight);

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
            sb.DrawString(font, "You Got The Triforce Piece!", new Vector2(170, 210), Color.White);
            sb.DrawString(font, "Press Enter to Restart", new Vector2(200, 250), Color.White);

            sb.End();
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
