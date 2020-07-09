using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class ItemFire : AbstractItem
    {
        public ItemFire()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateItemFire();
            Position = Constant.ItemStartPosition;
        }
    }
}
