﻿using Microsoft.Xna.Framework;
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
        private ISprite sprite;
        private Vector2 position;

        public UsableBomb(ILink link)
        {
            this.link = link;
            sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
        }

        public void UseLeft()
        {
            position.X = link.Position.X - Constant.BombOffset;
        }

        public void UseRight()
        {
            position.X = link.Position.X + Constant.BombOffset;
        }

        public void UseUp()
        {
            position.Y = link.Position.Y - Constant.BombOffset;
        }

        public void UseDown()
        {
            position.Y = link.Position.Y + Constant.BombOffset;
        }
    }
}
