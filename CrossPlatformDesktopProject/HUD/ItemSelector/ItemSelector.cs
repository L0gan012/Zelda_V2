using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Sprint2
{
    public class ItemSelector: IItemSelector
    {

        private Vector2 selectorPosition;
        private IPlayer user;

        //public IUsableItem Selected { get; private set; }

        public ItemSelector(IPlayer user)
        {
            this.user = user;
            selectorPosition = Constant.ItemSelectorStartPosition;
        }

        public void SelectDown()
        {
            if(selectorPosition.Y < Constant.ItemSelectorYLimit)
            {
                selectorPosition.Y += Constant.ItemHeight;
            }
        }

        public void SelectLeft()
        {
            if (selectorPosition.X > Constant.ItemSelectorStartPosition.X)
            {
                selectorPosition.X -= Constant.ItemHeight;
            }
        }

        public void SelectRight()
        {
            if (selectorPosition.X < Constant.ItemSelectorXLimit)
            {
                selectorPosition.X += Constant.ItemWidth;
            }
        }

        public void SelectUp()
        {
            if (selectorPosition.Y > Constant.ItemSelectorStartPosition.Y)
            {
                selectorPosition.Y -= Constant.ItemHeight;
            }
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(KeyValuePair<IItem, IUsableItem> keyValuePair in user.Inventory.ItemCache)
            {
                Color color = keyValuePair.Key.Color;
                Vector2 position = keyValuePair.Value.InventoryPosition;
                keyValuePair.Key.Sprite.Draw(spriteBatch, color, position);
            }
        }
    }
}
