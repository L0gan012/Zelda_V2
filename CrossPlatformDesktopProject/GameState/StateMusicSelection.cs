using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class StateMusicSelection : IGameState
    {
        public Game1 Game { get; set; }
        private SpriteBatch spriteBatch;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;
        private ISprite fairy;
        public static Vector2 vector { get; set; }

        public StateMusicSelection()
        {
            Game = Game1.Instance;
            Game.State = this;
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            rect = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });

            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
            fairy = ItemsSpriteFactory.Instance.CreateSpriteFairy();
            vector = new Vector2(400, 100);
        }

        public void Update()
        {

            foreach (IController controller in Game.Controllers)
            {
                controller.Update();
            }
            fairy.Update();
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Begin();
            sb.Draw(background, rect, Color.Black);
            sb.DrawString(font, "Controls", new Vector2(150, 100), Color.White);
            sb.DrawString(font, "Music", new Vector2(150, 200), Color.White);
            sb.DrawString(font, "Resoultion", new Vector2(150, 300), Color.White);
            sb.DrawString(font, "Tab - Up & Down", new Vector2(200, 550), Color.White);
            sb.DrawString(font, "b - Go Back", new Vector2(200, 600), Color.White);
            sb.DrawString(font, "space - Game Start", new Vector2(200, 650), Color.White);
            sb.End();
            fairy.Draw(sb, Color.White, vector);

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
