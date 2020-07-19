using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class MiniHUD
    {
        private IPlayer user;
        private IMap miniMap;
        private IHealthBar health;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        public MiniHUD(IPlayer user)
        {
            rect = new Rectangle(0, 0, Constant.HUDWidth, Constant.HUDHeight);

            this.user = user;
            miniMap = new MiniMap(user);
            health = new HealthBar(user);
        }

        public void Update()
        {
            miniMap.Update();
            health.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            DrawText(spriteBatch);
            DrawSprites(spriteBatch);
            health.Draw(spriteBatch);
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
            spriteBatch.DrawString(font, "X" + user.Inventory.RupeeCount, Constant.RupeeCountPosition, Color.White);
            spriteBatch.DrawString(font, "X" + user.Inventory.KeyCount, Constant.KeyCountPosition, Color.White);
            spriteBatch.DrawString(font, "X" + user.Inventory.BombCount, Constant.BombCountPosition, Color.White);
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
