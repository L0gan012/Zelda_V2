using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class HeadsUpDisplay
    {
        private IPlayer user;
        private IMap bigMap;
        private IMap miniMap;
        private IInventory inventory;
        private IHealthBar health;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        public HeadsUpDisplay(IPlayer user)
        {
            rect = new Rectangle(0, 0, Constant.HUDWidth, Constant.HUDHeight);

            this.user = user;
            bigMap = new Map();
            miniMap = new MiniMap(user);
            inventory = user.Inventory;
            health = new HealthBar(user);
        }

        public void Update()
        {
            miniMap.Update();
            health.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, rect, Color.Black);
            spriteBatch.DrawString(font, "LEVEL-1", new Vector2(50, 10), Color.White);
            spriteBatch.End();

            health.Draw(spriteBatch);
            //bigMap.Draw(spriteBatch);
            miniMap.Draw(spriteBatch);
        }

        public void LoadHUDTextures()
        {
            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });

            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
        }
    }
}
