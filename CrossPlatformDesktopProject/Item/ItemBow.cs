﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemBow : AbstractItem
    {
        public ItemBow()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBow();
            Position = Constant.ItemStartPosition;
        }
    }
}
