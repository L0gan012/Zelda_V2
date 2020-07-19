using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class HealthBar: IHealthBar
    {
        private IPlayer user;
        private int fullHearts;
        private bool hasHalfHeart;
        private int emptyHearts;
        private Color color;

        public HealthBar(IPlayer player)
        {
            user = player;
            fullHearts = 0;
            hasHalfHeart = false;
            emptyHearts = 0;
            color = Color.White;
        }

        public void Update()
        {
            fullHearts = (int) user.HP;
            emptyHearts = (int)(user.MaxHP - user.HP);
            float junk = user.HP - fullHearts;
            if(.5f < junk)
            {
                fullHearts++;
                hasHalfHeart = false;
            }
            else if(0 < junk)
            {
                hasHalfHeart = true;
            } else if (junk == 0)
            {
                hasHalfHeart = false;
            }


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 location = Constant.HealthBarLocation;
            for(int i = 0; i < fullHearts; i++)
            {
                ISprite heart = HUDSpriteFactory.Instance.CreateHUDFullHeart();
                heart.Draw(spriteBatch, color, location);

                location.X += Constant.HeartWidth;
            }

            if (hasHalfHeart)
            {
                ISprite halfHeart = HUDSpriteFactory.Instance.CreateHUDHalfHeart();
                halfHeart.Draw(spriteBatch, color, location);
                location.X += Constant.HeartWidth;
            }

            for(int i = 0; i < emptyHearts; i++)
            {
                ISprite halfHeart = HUDSpriteFactory.Instance.CreateHUDNoHeart();
                halfHeart.Draw(spriteBatch, color, location);
                location.X += Constant.HeartWidth;
            }
        }
    }
}
