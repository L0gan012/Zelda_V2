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
            float partialHearts = user.HP - fullHearts;
            if(.5f < partialHearts)
            {
                fullHearts++;
                hasHalfHeart = false;
            }
            else if(0 < partialHearts)
            {
                hasHalfHeart = true;
            } else if (partialHearts == 0)
            {
                hasHalfHeart = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 location = MiniHUD.MiniHUDPosition + new Vector2(HUDConstants.HealthBarLocation.X * Constant.DisplayScaleX, HUDConstants.HealthBarLocation.Y * Constant.DisplayScaleY);
            for(int i = 0; i < fullHearts; i++)
            {
                ISprite heart = HUDSpriteFactory.Instance.CreateHUDFullHeart();
                heart.Draw(spriteBatch, color, location);

                location.X += HUDConstants.HeartWidth * Constant.DisplayScaleX;
            }

            if (hasHalfHeart)
            {
                ISprite halfHeart = HUDSpriteFactory.Instance.CreateHUDHalfHeart();
                halfHeart.Draw(spriteBatch, color, location);
                location.X += HUDConstants.HeartWidth * Constant.DisplayScaleX;
            }

            for(int i = 0; i < emptyHearts; i++)
            {
                ISprite halfHeart = HUDSpriteFactory.Instance.CreateHUDNoHeart();
                halfHeart.Draw(spriteBatch, color, location);
                location.X += HUDConstants.HeartWidth * Constant.DisplayScaleX;
            }
        }
    }
}
