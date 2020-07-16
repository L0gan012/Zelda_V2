using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class HeadsUpDisplay
    {
        private IPlayer user;
        private IMap bigMap;
        private IInventory inventory;
        private ISprite[,] MiniMap;
        private float health;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        public HeadsUpDisplay(IPlayer user)
        {
            rect = new Rectangle(0, 0, Constant.HUDWidth, Constant.HUDHeight);
            MiniMap = new ISprite[Constant.DungeonGridHeight, Constant.DungeonGridWidth];

            this.user = user;
            bigMap = new Map(user);
            inventory = user.Inventory;
            health = user.MaxHP;
        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, rect, Color.Black);
            DrawRectangle(spriteBatch, rect, Color.Blue);
            spriteBatch.DrawString(font, "LEVEL-1", Vector2.Zero, Color.White);
            spriteBatch.End();
            //bigMap.Draw(spriteBatch);
        }

        private void DrawRectangle(SpriteBatch spriteBatch, Rectangle rect, Color color)
        {
            spriteBatch.Draw(background, new Rectangle(rect.Left, rect.Top, rect.Width, 1), color);
            spriteBatch.Draw(background, new Rectangle(rect.Left, rect.Bottom, rect.Width, 1), color);
            spriteBatch.Draw(background, new Rectangle(rect.Left, rect.Top, 1, rect.Height), color);
            spriteBatch.Draw(background, new Rectangle(rect.Right, rect.Top, 1, rect.Height), color);
        }

        public void LoadHUDTextures()
        {
            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });

            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
        }
    }
}
