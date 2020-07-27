using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class ItemSelector : IItemSelector
    {

        private Vector2 selectorPosition;
        private IPlayer user;
        private int selectorIndex;
        private List<IItem> items;
        private ISprite selector;

        public IItem SelectedItem
        {
            get
            {
                return items[selectorIndex];
            }
        }

        public ItemSelector(IPlayer user)
        {
            this.user = user;
            selectorPosition = new Vector2(HUDConstants.ItemSelectorStartPosition.X * Constant.DisplayScaleX, HUDConstants.ItemSelectorStartPosition.Y * Constant.DisplayScaleY);
            selector = HUDSpriteFactory.Instance.CreateHUDItemSelector();

            items = new List<IItem>(user.Inventory.ItemCache.Keys);
            selectorIndex = 0;
            Select();
        }

        public void SelectForward()
        {
            selectorIndex++;
            if(selectorIndex >= items.Count)
            {
                selectorIndex = 0;
            }
            Select();
        }

        private void Select()
        {
            if (items.Count > 0)
            {
                selectorPosition = user.Inventory.ItemCache[SelectedItem].InventoryPosition;
                selectorPosition.X -= HUDConstants.ItemSelectorOffset.X * Constant.DisplayScaleX;
                selectorPosition.Y -= HUDConstants.ItemSelectorOffset.Y * Constant.DisplayScaleY;
                user.SecondaryItem = user.Inventory.ItemCache[SelectedItem];
            }
        }


        public void Update()
        {
            items = new List<IItem>(user.Inventory.ItemCache.Keys);
            selector.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(KeyValuePair<IItem, IUsableItem> keyValuePair in user.Inventory.ItemCache)
            {
                Color color = keyValuePair.Key.Color;
                Vector2 position = keyValuePair.Value.InventoryPosition;
                keyValuePair.Key.Sprite.Draw(spriteBatch, color, position);
            }

            selector.Draw(spriteBatch, Color.White, selectorPosition);
        }
    }
}
