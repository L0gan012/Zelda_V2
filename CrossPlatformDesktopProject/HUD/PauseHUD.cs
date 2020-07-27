using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class PauseHUD
    {
        private IPlayer user;
        private IMap bigMap;
        private MiniHUD miniHUD;

        private Texture2D background;
        private SpriteFont font;

        public IItemSelector ItemSelector { get; set; }

        public PauseHUD(IPlayer user, MiniHUD miniHUD)
        {
            this.user = user;
            this.miniHUD = miniHUD;

            bigMap = new Map();
            ItemSelector = new ItemSelector(user);
        }

        public void Update()
        {
            miniHUD.Update();
            bigMap.Update();
            ItemSelector.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            DrawText(spriteBatch);
            DrawSprites(spriteBatch);
            miniHUD.Draw(spriteBatch);
            bigMap.Draw(spriteBatch);
            ItemSelector.Draw(spriteBatch);
        }

        private void DrawSprites(SpriteBatch spriteBatch)
        {
            HUDSpriteFactory.Instance.CreateHUDSecondaryItemBox().Draw(spriteBatch, Color.White, new Vector2(HUDConstants.SelectedItemBoxPosition.X * Constant.DisplayScaleX, HUDConstants.SelectedItemBoxPosition.Y * Constant.DisplayScaleY));
            HUDSpriteFactory.Instance.CreateHUDInventoryBox().Draw(spriteBatch, Color.White, new Vector2(HUDConstants.InventoryBoxPosition.X * Constant.DisplayScaleX, HUDConstants.InventoryBoxPosition.Y * Constant.DisplayScaleY));
            if (user.Inventory.HasMap)
            {
                ItemsSpriteFactory.Instance.CreateSpriteMap().Draw(spriteBatch, Color.White, new Vector2(HUDConstants.HasMapPosition.X * Constant.DisplayScaleX, HUDConstants.HasMapPosition.Y * Constant.DisplayScaleY));
            }
            if (user.Inventory.HasCompass)
            {
                ItemsSpriteFactory.Instance.CreateSpriteCompass().Draw(spriteBatch, Color.White, new Vector2(HUDConstants.HasCompassPosition.X * Constant.DisplayScaleX, HUDConstants.HasCompassPosition.Y * Constant.DisplayScaleY));
            }
            if(ItemSelector.SelectedItem != null)
            {
                ItemSelector.SelectedItem.Sprite.Draw(spriteBatch, Color.White, new Vector2(HUDConstants.SelectedItemPosition.X * Constant.DisplayScaleX, HUDConstants.SelectedItemPosition.Y * Constant.DisplayScaleY));
            }
        }

        private void DrawText(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, new Rectangle(0, 0, (int)(HUDConstants.PauseHUDWidth * Constant.DisplayScaleX), (int)(HUDConstants.PauseHUDHeight * Constant.DisplayScaleY)), Color.Black);
            spriteBatch.DrawString(font, "INVENTORY", new Vector2(34 * Constant.DisplayScaleX, 24 * Constant.DisplayScaleY), Color.Red);
            spriteBatch.DrawString(font, "USE B BUTTON", new Vector2(16 * Constant.DisplayScaleX, 72 * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(font, "FOR THIS", new Vector2(32 * Constant.DisplayScaleX, 80 * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(font, "MAP", new Vector2(40 * Constant.DisplayScaleX, 96 * Constant.DisplayScaleY), Color.Red);
            spriteBatch.DrawString(font, "COMPASS", new Vector2(24 * Constant.DisplayScaleX, 136 * Constant.DisplayScaleY), Color.Red);
        }

        public void LoadHUDTextures()
        {
            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });

            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
        }
    }
}
