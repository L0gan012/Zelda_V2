using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class MiniHUD
    {
        private IPlayer user;
        private IMap miniMap;
        private IHealthBar health;

        private Texture2D background;
        private SpriteFont font;

        public static Vector2 MiniHUDPosition;

        public MiniHUD(IPlayer user)
        {
            MiniHUDPosition = new Vector2();

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
            HUDSpriteFactory.Instance.CreateHUDRupee().Draw(spriteBatch, Color.White, MiniHUDPosition + Constant.RupeePosition);
            HUDSpriteFactory.Instance.CreateHUDKey().Draw(spriteBatch, Color.White, MiniHUDPosition + Constant.KeyPosition);
            HUDSpriteFactory.Instance.CreateHUDBomb().Draw(spriteBatch, Color.White, MiniHUDPosition + Constant.BombPosition);
            HUDSpriteFactory.Instance.CreateHUDBSlot().Draw(spriteBatch, Color.White, MiniHUDPosition + Constant.BSlotPosition);
            HUDSpriteFactory.Instance.CreateHUDASlot().Draw(spriteBatch, Color.White, MiniHUDPosition + Constant.ASlotPosition);
            ItemsSpriteFactory.Instance.CreateSpriteWoodenSword().Draw(spriteBatch, Color.White, MiniHUDPosition + Constant.PrimaryItemPosition);
            Game1.Instance.PauseHUD.ItemSelector.SelectedItem.Sprite.Draw(spriteBatch, Color.White, MiniHUDPosition + Constant.SecondaryItemPosition);
        }

        private void DrawText(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, new Rectangle((int)MiniHUDPosition.X, (int)MiniHUDPosition.Y, Constant.HUDWidth, Constant.HUDHeight), Color.Black);
            spriteBatch.DrawString(font, "LEVEL-1", MiniHUDPosition + new Vector2(18 * Constant.DisplayScaleX, 4 * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(font, "-LIFE-", MiniHUDPosition + Constant.HealthBarLocation + new Vector2(8 * Constant.DisplayScaleX, -24 * Constant.DisplayScaleY), Color.Red);
            spriteBatch.DrawString(font, "X" + user.Inventory.RupeeCount, MiniHUDPosition + Constant.RupeeCountPosition, Color.White);
            spriteBatch.DrawString(font, "X" + user.Inventory.KeyCount, MiniHUDPosition + Constant.KeyCountPosition, Color.White);
            spriteBatch.DrawString(font, "X" + user.Inventory.BombCount, MiniHUDPosition + Constant.BombCountPosition, Color.White);
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
