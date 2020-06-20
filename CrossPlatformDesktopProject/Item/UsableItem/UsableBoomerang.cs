using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class UsableBoomerang : AbstractItem, IUsableItem
    {
        private ILink link;

        private Vector2 startCenter;

        private Rectangle boomerangPerimeter;
        private int deltaX;
        private int deltaY;

        private Boolean returning;

        public UsableBoomerang(ILink link)
        {
            this.link = link;
            startCenter = link.Center;
            boomerangPerimeter = new Rectangle((int)link.Center.X - Constant.BoomerangDistance, (int)link.Center.Y - Constant.BoomerangDistance, Constant.BoomerangDistance*2, Constant.BoomerangDistance*2);
            returning = false;

            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenBoomerang();
            Color = Color.White;
        }

        public override void Update()
        {
            if (boomerangPerimeter.Contains(Location.X, Location.Y) && !returning)
            {
                Location = new Vector2(Location.X + deltaX * Constant.BoomerangSpeed, Location.Y + deltaY * Constant.BoomerangSpeed);
            }
            //Change to Rectangle.Interset when collision is put in
            else if ((Convert.ToInt32(Location.X) != Convert.ToInt32(link.Center.X)) || (Convert.ToInt32(Location.Y) != Convert.ToInt32(link.Center.Y)))
            {
                returning = true;
                if (Location.X < link.Center.X)
                {
                    deltaX = 1;
                }
                else if (Location.X > link.Center.X)
                {
                    deltaX = -1;
                }
                else
                {
                    deltaX = 0;
                }

                if (Location.Y < link.Center.Y)
                {
                    deltaY = 1;
                }
                else if (Location.Y > link.Center.Y)
                {
                    deltaY = -1;
                }
                else
                {
                    deltaY = 0;
                }
                Location = new Vector2(Location.X + deltaX * Constant.BoomerangSpeed, Location.Y + deltaY * Constant.BoomerangSpeed);
            }
            else
            {
                link.Item = null;
            }

            Sprite.Update();
        }

        public void UseDown()
        {
            Location = new Vector2(startCenter.X, startCenter.Y + Constant.ItemOffset);
            deltaX = 0;
            deltaY = 1;
        }

        public void UseLeft()
        {
            Location = new Vector2(startCenter.X - Constant.ItemOffset, startCenter.Y);
            deltaX = -1;
            deltaY = 0;
        }

        public void UseRight()
        {
            Location = new Vector2(startCenter.X + Constant.ItemOffset, startCenter.Y);
            deltaX = 1;
            deltaY = 0;
        }

        public void UseUp()
        {
            Location = new Vector2(startCenter.X, startCenter.Y - Constant.ItemOffset);
            deltaX = 0;
            deltaY = -1;
        }
    }
}
