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
    public class ItemPowerBracelet : AbstractItem
    {
        public ItemPowerBracelet()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpritePowerBracelet();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
