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
            background = new Texture2D(Game.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });

            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
            fairy = ItemsSpriteFactory.Instance.CreateSpriteFairy();
            vector = new Vector2(260, 50);
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
            sb.DrawString(font, "Music Settings", new Vector2(0, 0), Color.White);
            sb.DrawString(font, "Gerudo Valley", new Vector2(0, 50), Color.White);
            sb.DrawString(font, "Lost Woods", new Vector2(0, 100), Color.White);
            sb.DrawString(font, "Princess Zelda", new Vector2(0, 150), Color.White);
            sb.DrawString(font, "Dragon Roost Island", new Vector2(0, 200), Color.White);
            sb.DrawString(font, "Great Fairy Fountain", new Vector2(0, 250), Color.White);
            sb.DrawString(font, "Hyrule Field", new Vector2(0, 300), Color.White);
            sb.DrawString(font, "Kakariko Village", new Vector2(0, 350), Color.White);
            sb.DrawString(font, "Lorule Castle A Link Between Worlds", new Vector2(0, 400), Color.White);
            sb.DrawString(font, "Midna's Lament", new Vector2(0, 450), Color.White);
            sb.DrawString(font, "Wind Waker", new Vector2(0, 500), Color.White);
            sb.DrawString(font, "Zedd Legend Of Zelda HD Remix", new Vector2(0, 550), Color.White);
            sb.DrawString(font, "Tab - Up & Down ", new Vector2(300, 600), Color.White);
            sb.DrawString(font, "b - Go Back", new Vector2(0, 650), Color.White);
            sb.DrawString(font, "space - Select Option", new Vector2(300, 650), Color.White);
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
