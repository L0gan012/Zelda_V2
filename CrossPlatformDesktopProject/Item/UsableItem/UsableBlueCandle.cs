using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBlueCandle : AbstractItem, IUsableItem
    {
        private ILink link;
        private float deltaX;
        private float deltaY;
        private float xLimit;
        private float yLimit;

        public UsableBlueCandle(ILink link)
        {
            this.link = link;
            Color = Color.White;
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileFlame();
          
        }

        public void UseLeft()
        {
            Location = new Vector2(link.Position.X - Constant.ItemOffset, link.Position.Y);
            deltaX = -1;
            deltaY = 0;
            xLimit = Location.X - Constant.FlameDistance;
            yLimit = Location.Y;
            

        }

        public void UseRight()
        {
            Location = new Vector2(link.Position.X + Constant.ItemOffset, link.Position.Y);
            deltaX = 1;
            deltaY = 0;
            xLimit = Location.X + Constant.FlameDistance;
            yLimit = Location.Y;
            
        }

        public void UseUp()
        {
            Location = new Vector2(link.Position.X, link.Position.Y - Constant.ItemOffset);
            deltaX = 0;
            deltaY = -1;
            xLimit = Location.X;
            yLimit = Location.Y - Constant.FlameDistance;
        }

        public void UseDown()
        {
            Location = new Vector2(link.Position.X, link.Position.Y + Constant.ItemOffset);
            deltaX = 0;
            deltaY = 1;
            xLimit = Location.X;
            yLimit = Location.Y + Constant.FlameDistance;
        }


        public override void Update()
        {

            Location = new Vector2(Location.X + deltaX, Location.Y + deltaY);

            if((0 > Location.X || Location.X == xLimit) && (0 > Location.Y || Location.Y == yLimit))
            {
                link.Item = null;
            }
            
        }

    }
}
