using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Sprite.Update();
            timer--;

            if(timer == 0)
            {
                Link.Item = null;
            }
        }
    }
}
