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

        public PauseHUD(IPlayer user)
        {
            this.user = user;

            bigMap = new Map();
            inventory = user.Inventory;
            itemSelector = new ItemSelector(user);
        }

        public void Update()
        {
            //bigMap.Update();
            itemSelector.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //bigMap.Draw(spriteBatch);
            itemSelector.Draw(spriteBatch);
        }

        private void DrawSprites(SpriteBatch spriteBatch)
        {
            //HUDSpriteFactory.Instance.CreateHUDSecondaryItemBox().Draw(spriteBatch, Color.White, Constant.SecondaryItemBoxPosition);
            HUDSpriteFactory.Instance.CreateHUDKey().Draw(spriteBatch, Color.White, Constant.KeyPosition);
            HUDSpriteFactory.Instance.CreateHUDBomb().Draw(spriteBatch, Color.White, Constant.BombPosition);
            HUDSpriteFactory.Instance.CreateHUDBSlot().Draw(spriteBatch, Color.White, Constant.BSlotPosition);
            HUDSpriteFactory.Instance.CreateHUDASlot().Draw(spriteBatch, Color.White, Constant.ASlotPosition);
        }

        private void DrawText(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            /*spriteBatch.DrawString(font, "LEVEL-1", new Vector2(50, 10), Color.White);
            spriteBatch.DrawString(font, "-LIFE-", Constant.HealthBarLocation + new Vector2(8 * Constant.DisplayScaleX, -24 * Constant.DisplayScaleY), Color.Red);
            spriteBatch.DrawString(font, "X" + user.Inventory.RupeeCount, Constant.RupeeCountPosition, Color.White);
            spriteBatch.DrawString(font, "X" + user.Inventory.KeyCount, Constant.KeyCountPosition, Color.White);
            spriteBatch.DrawString(font, "X" + user.Inventory.BombCount, Constant.BombCountPosition, Color.White);*/
            spriteBatch.End();
        }
    }
}
