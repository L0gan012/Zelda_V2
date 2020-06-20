﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class UsableBomb : AbstractItem, IUsableItem
    {
        private ILink link;
        private int timer;

        public UsableBomb(ILink link)
        {
            this.link = link;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            Color = Color.White;
            timer = Constant.BombTimer;
        }
        
        public override void Update()
        {

            Sprite.Update();
            timer--;

            if(timer == 0)
            {
                link.Item = null;
            }
        }

        public void UseLeft()
        {
            Location = new Vector2(link.Center.X - Constant.ItemOffset, link.Center.Y);
        }

        public void UseRight()
        {
            Location = new Vector2(link.Center.X + Constant.ItemOffset, link.Center.Y);
        }

        public void UseUp()
        {
            Location = new Vector2(link.Center.X, link.Center.Y - Constant.ItemOffset);
        }

        public void UseDown()
        {
            Location = new Vector2(link.Center.X, link.Center.Y + Constant.ItemOffset);
        }
    }
}
