using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Item
{
    public class ItemBluePotion : AbstractItem
    {
        public ItemBluePotion()
        {
            sprite = ItemsSpriteFactory.Instance.CreateSpriteBluePotion();
            location = Constant.ItemStartPosition;
            color = Color.White;
        }
    }
}
