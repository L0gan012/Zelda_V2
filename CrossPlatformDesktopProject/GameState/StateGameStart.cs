using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateGameStart : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;
        private IGameState state;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        public StateGameStart(IGameState state)
        {
            Game = Game1.Instance;
            this.state = state;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            rect = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);

            background = Game1.Instance.Content.Load<Texture2D>("TextureSheets/SpriteSourceFiles/StartSheet");
            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
            SoundManager.Instance.PlayIntroMusic();
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

            sb.Draw(background, rect, Color.White);
            sb.DrawString(font, "Push Space Button", new Vector2(Constant.ScreenWidth / 4, 550), Color.Black);
            sb.End();
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
