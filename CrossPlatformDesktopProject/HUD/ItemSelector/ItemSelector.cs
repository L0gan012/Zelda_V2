using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class ItemSelector: IItemSelector
    {

        private Vector2 selectorPosition;
        private IPlayer user;
        private int selectorIndex;
        private List<IUsableItem> items;
        private ISprite selector;

        public ItemSelector(IPlayer user)
        {
            this.user = user;
            selectorPosition = Constant.ItemSelectorStartPosition;
            selector = HUDSpriteFactory.Instance.CreateHUDItemSelector();

            items = new List<IUsableItem>(user.Inventory.ItemCache.Values);
            selectorIndex = 0;
            Select();
        }

        public void SelectForward()
        {
            if( selectorIndex + 1 < items.Count)
            {
                selectorIndex++;
            }
            Select();
        }

        public void SelectBack()
        {
            if (selectorIndex - 1 >= 0)
            {
                selectorIndex--;
            }
            Select();
        }

        private void Select()
        {
            if (items.Count < 0)
            {
                selectorPosition = items.ElementAt(selectorIndex).InventoryPosition;
                user.SecondaryItem = items.ElementAt(selectorIndex);
            }
        }


        public void Update()
        {
            items = new List<IUsableItem>(user.Inventory.ItemCache.Values);
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
