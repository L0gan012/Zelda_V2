using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBlueCandle : AbstractItem, IUsableItem
    {
        private ILink link;
        private float deltaX;
        private float deltaY;
        private Rectangle range;

        public UsableBlueCandle(ILink link)
        {
            this.link = link;
            Color = Color.White;
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileCandle();
            int distance = Constant.FlameDistance;
            range = new Rectangle((int)link.Center.X - distance, (int)link.Center.Y - distance, + 2*distance, 2*distance) ;
          
        }

        public override void Update()
        {
            Location = new Vector2(Location.X + deltaX * Constant.FlameSpeed, Location.Y + deltaY * Constant.FlameSpeed);

            if (!range.Contains(Center))
            {
                link.Item = null;
            }
        }

        public void UseLeft()
        {
            Location = new Vector2(link.Center.X - Constant.ItemOffset - Sprite.GetWidth()/2, link.Center.Y - Sprite.GetHeight()/2);
            deltaX = -1;
            deltaY = 0;
        }

        public void UseRight()
        {
            Location = new Vector2(link.Center.X + Constant.ItemOffset - Sprite.GetWidth()/2, link.Center.Y - Sprite.GetHeight()/2);
            deltaX = 1;
            deltaY = 0;
        }

        public void UseUp()
        {
            Location = new Vector2(link.Center.X - Sprite.GetWidth()/2, link.Center.Y - Constant.ItemOffset - Sprite.GetHeight()/2);
            deltaX = 0;
            deltaY = -1;
        }

        public void UseDown()
        {
            Location = new Vector2(link.Center.X - Sprite.GetWidth()/2, link.Center.Y + Constant.ItemOffset - Sprite.GetHeight()/2);
            deltaX = 0;
            deltaY = 1;
        }
    }
}
