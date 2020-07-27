using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class MiniHUD
    {
        private IPlayer user;
        private IMap miniMap;
        private IHealthBar health;

        private Texture2D background;
        private SpriteFont font;

        public static Dictionary<int, IRoom> DiscoveredRooms { get; private set; } = new Dictionary<int, IRoom>();
        public static Vector2 MiniHUDPosition;

        public MiniHUD(IPlayer user)
        {
            MiniHUDPosition = new Vector2(0, 0);

            this.user = user;
            miniMap = new MiniMap(user);
            health = new HealthBar(user);
        }

        public void Update()
        {
            DiscoverRooms();
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
            HUDSpriteFactory.Instance.CreateHUDRupee().Draw(spriteBatch, Color.White, MiniHUDPosition + new Vector2(HUDConstants.RupeePosition.X * Constant.DisplayScaleX, HUDConstants.RupeePosition.Y * Constant.DisplayScaleY));
            HUDSpriteFactory.Instance.CreateHUDKey().Draw(spriteBatch, Color.White, MiniHUDPosition + new Vector2(HUDConstants.KeyPosition.X * Constant.DisplayScaleX, HUDConstants.KeyPosition.Y * Constant.DisplayScaleY));
            HUDSpriteFactory.Instance.CreateHUDBomb().Draw(spriteBatch, Color.White, MiniHUDPosition + new Vector2(HUDConstants.BombPosition.X * Constant.DisplayScaleX, HUDConstants.BombPosition.Y * Constant.DisplayScaleY));
            HUDSpriteFactory.Instance.CreateHUDBSlot().Draw(spriteBatch, Color.White, MiniHUDPosition + new Vector2(HUDConstants.BSlotPosition.X * Constant.DisplayScaleX, HUDConstants.BSlotPosition.Y * Constant.DisplayScaleY));
            HUDSpriteFactory.Instance.CreateHUDASlot().Draw(spriteBatch, Color.White, MiniHUDPosition + new Vector2(HUDConstants.ASlotPosition.X * Constant.DisplayScaleX, HUDConstants.ASlotPosition.Y * Constant.DisplayScaleY));
            ItemsSpriteFactory.Instance.CreateSpriteWoodenSword().Draw(spriteBatch, Color.White, MiniHUDPosition + new Vector2(HUDConstants.PrimaryItemPosition.X * Constant.DisplayScaleX, HUDConstants.PrimaryItemPosition.Y * Constant.DisplayScaleY));
            Game1.Instance.PauseHUD.ItemSelector.SelectedItem.Sprite.Draw(spriteBatch, Color.White, MiniHUDPosition + new Vector2(HUDConstants.SecondaryItemPosition.X * Constant.DisplayScaleX, HUDConstants.SecondaryItemPosition.Y * Constant.DisplayScaleY));
        }

        private void DrawText(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(background, new Rectangle((int)MiniHUDPosition.X, (int)MiniHUDPosition.Y, (int)(HUDConstants.HUDWidth * Constant.DisplayScaleX), (int)(HUDConstants.HUDHeight * Constant.DisplayScaleY)), Color.Black);
            spriteBatch.DrawString(font, "LEVEL-1", MiniHUDPosition + new Vector2(18 * Constant.DisplayScaleX, 4 * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(font, "-LIFE-", MiniHUDPosition + new Vector2(HUDConstants.HealthBarLocation.X * Constant.DisplayScaleX, HUDConstants.HealthBarLocation.Y * Constant.DisplayScaleY) + new Vector2(8 * Constant.DisplayScaleX, -24 * Constant.DisplayScaleY), Color.Red);
            spriteBatch.DrawString(font, "X" + user.Inventory.RupeeCount, MiniHUDPosition + new Vector2(HUDConstants.RupeeCountPosition.X * Constant.DisplayScaleX, HUDConstants.RupeeCountPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(font, "X" + user.Inventory.KeyCount, MiniHUDPosition + new Vector2(HUDConstants.KeyCountPosition.X * Constant.DisplayScaleX, HUDConstants.KeyCountPosition.Y * Constant.DisplayScaleY), Color.White);
            spriteBatch.DrawString(font, "X" + user.Inventory.BombCount, MiniHUDPosition + new Vector2(HUDConstants.BombCountPosition.X * Constant.DisplayScaleX, HUDConstants.BombCountPosition.Y * Constant.DisplayScaleY), Color.White);
        }

        public void LoadHUDTextures()
        {
            background = new Texture2D(Game1.Instance.GraphicsDevice, 1, 1);
            background.SetData(new Color[] { Color.White });

            font = Game1.Instance.Content.Load<SpriteFont>("Fonts/Font");
        }

        public void DiscoverRooms()
        {
            if (!DiscoveredRooms.ContainsKey(GameObjects.Instance.LevelListPosition))
            {
                DiscoveredRooms.Add(GameObjects.Instance.LevelListPosition, GameObjects.Instance.currentRoom);

            }

        }
    }
}
