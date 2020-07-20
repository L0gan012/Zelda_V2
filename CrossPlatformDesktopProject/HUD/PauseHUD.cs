using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class PauseHUD
    {
        private IPlayer user;
        private IMap bigMap;
        private IInventory inventory;
        private IItemSelector itemSelector;
        private MiniHUD miniHUD;

        private Rectangle rect;
        private Texture2D background;
        private SpriteFont font;

        public PauseHUD(IPlayer user, MiniHUD miniHUD)
        {
            rect = new Rectangle(0, 0, Constant.PauseHUDWidth, Constant.PauseHUDHeight);

            this.user = user;
            this.miniHUD = miniHUD;

            bigMap = new Map();
            inventory = user.Inventory;
            itemSelector = new ItemSelector(user);
        }

        public void Update()
        {
            miniHUD.Update();
            bigMap.Update();
            itemSelector.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            DrawText(spriteBatch);
            DrawSprites(spriteBatch);
            miniHUD.Draw(spriteBatch);
            bigMap.Draw(spriteBatch);
            itemSelector.Draw(spriteBatch);
        }

        private void DrawSprites(SpriteBatch spriteBatch)
        {
            HUDSpriteFactory.Instance.CreateHUDSecondaryItemBox().Draw(spriteBatch, Color.White, Constant.SecondaryItemBoxPosition);
            HUDSpriteFactory.Instance.CreateHUDInventoryBox().Draw(spriteBatch, Color.White, Constant.InventoryBoxPosition);
        }

        private void DrawText(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, rect, Color.Black);
            spriteBatch.DrawString(font, "INVENTORY", new Vector2(34 * Constant.DisplayScaleX, 24 * Constant.DisplayScaleY), Color.Red);
            spriteBatch.DrawString(font, "USE B BUTTON", new Vector2(16 * Constant.DisplayScaleX, 72 * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(font, "FOR THIS", new Vector2(32 * Constant.DisplayScaleX, 80 * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(font, "MAP", new Vector2(40 * Constant.DisplayScaleX, 96 * Constant.DisplayScaleY), Color.Red);
            spriteBatch.DrawString(font, "COMPASS", new Vector2(24 * Constant.DisplayScaleX, 136 * Constant.DisplayScaleY), Color.Red);
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
