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
            //bigMap.Update();
            miniMap.Update();
            health.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            DrawText(spriteBatch);
            DrawSprites(spriteBatch);
            health.Draw(spriteBatch);
            //bigMap.Draw(spriteBatch);
            miniMap.Draw(spriteBatch);
        }

        private void DrawSprites(SpriteBatch spriteBatch)
        {
            HUDSpriteFactory.Instance.CreateHUDRupee().Draw(spriteBatch, Color.White, Constant.RupeePosition);
            HUDSpriteFactory.Instance.CreateHUDKey().Draw(spriteBatch, Color.White, Constant.KeyPosition);
            HUDSpriteFactory.Instance.CreateHUDBomb().Draw(spriteBatch, Color.White, Constant.BombPosition);
            HUDSpriteFactory.Instance.CreateHUDBSlot().Draw(spriteBatch, Color.White, Constant.BSlotPosition);
            HUDSpriteFactory.Instance.CreateHUDASlot().Draw(spriteBatch, Color.White, Constant.ASlotPosition);
        }

        private void DrawText(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, rect, Color.Black);
            spriteBatch.DrawString(font, "LEVEL-1", new Vector2(50, 10), Color.White);
            spriteBatch.DrawString(font, "-LIFE-", Constant.HealthBarLocation + new Vector2(8 * Constant.DisplayScaleX, -24 * Constant.DisplayScaleY), Color.Red);
            spriteBatch.DrawString(font, "X" + inventory.RupeeCount, Constant.RupeeCountPosition, Color.White);
            spriteBatch.DrawString(font, "X" + inventory.KeyCount, Constant.KeyCountPosition, Color.White);
            spriteBatch.DrawString(font, "X" + inventory.BombCount, Constant.BombCountPosition, Color.White);
            spriteBatch.End();
        }

        public void LoadHUDTextures()
        {
            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });

            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
        }
    }
}
