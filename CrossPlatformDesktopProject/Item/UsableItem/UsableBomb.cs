﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBomb : AbstractUsable
    {
        private int timer;

        public UsableBomb(ILink link)
        {
            Link = link;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            Color = Color.White;
            timer = Constant.BombTimer;
        }
        
        public override void Update()
        {
            base.Update();
            timer--;

            if(timer == 0)
            {
                Link.Item = null;
            }

        }
    }
}
