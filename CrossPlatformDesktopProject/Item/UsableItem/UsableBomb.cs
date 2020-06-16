using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Item.UsableItem
{
    public class UsableBomb : AbstractItem, IUsableItem
    {
        private ILink link;

        public UsableBomb(ILink link)
        {
            this.link = link;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            Color = Color.White;
        }

        public void UseLeft()
        {
            Location = new Vector2(link.Position.X - Constant.BombOffset, Location.Y);
        }

        public void UseRight()
        {
            Location = new Vector2(link.Position.X + Constant.BombOffset, Location.Y);
        }

        public void UseUp()
        {
            Location = new Vector2(Location.X, link.Position.Y - Constant.BombOffset);
        }

        public void UseDown()
        {
            Location = new Vector2(Location.X, link.Position.Y + Constant.BombOffset);
        }
    }
}
