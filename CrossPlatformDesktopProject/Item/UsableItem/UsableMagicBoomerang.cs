using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class UsableMagicBoomerang : AbstractItem, IUsableItem
    {
        private ILink link;

        private Vector2 startCenter;

        private Rectangle boomerangPerimeter;
        private int deltaX;
        private int deltaY;

        private Boolean returning;

        public UsableMagicBoomerang(ILink link)
        {
            this.link = link;
            startCenter = link.Center;
            boomerangPerimeter = new Rectangle(Constant.DungeonWallWidth, Constant.DungeonWallHeight, Constant.ScreenWidth - 2 * Constant.DungeonWallWidth, Constant.ScreenHeight - 2 * Constant.DungeonWallHeight);
            returning = false;

            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileMagicBoomerang();
            Color = Color.White;
        }

        public override void Update()
        {
            if (boomerangPerimeter.Contains(Center) && !returning)
            {
                Location = new Vector2(Location.X + deltaX * Constant.BoomerangSpeed, Location.Y + deltaY * Constant.BoomerangSpeed);
            }
            //Change to Rectangle.Interset when collision is put in
            else if ((Convert.ToInt32(Location.X) != Convert.ToInt32(link.Center.X)) || (Convert.ToInt32(Location.Y) != Convert.ToInt32(link.Center.Y)))
            {
                returning = true;
                if (Center.X < link.Center.X)
                {
                    deltaX = 1;
                }
                else if (Center.X > link.Center.X)
                {
                    deltaX = -1;
                }
                else
                {
                    deltaX = 0;
                }

                if (Center.Y < link.Center.Y)
                {
                    deltaY = 1;
                }
                else if (Center.Y > link.Center.Y)
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
            Location = new Vector2(startCenter.X - Sprite.GetWidth() / 2, startCenter.Y + Constant.ItemOffset - Sprite.GetHeight() / 2);
            deltaX = 0;
            deltaY = 1;
        }

        public void UseLeft()
        {
            Location = new Vector2(startCenter.X - Constant.ItemOffset - Sprite.GetWidth() / 2, startCenter.Y - Sprite.GetHeight() / 2);
            deltaX = -1;
            deltaY = 0;
        }

        public void UseRight()
        {
            Location = new Vector2(startCenter.X + Constant.ItemOffset - Sprite.GetWidth() / 2, startCenter.Y - Sprite.GetHeight() / 2);
            deltaX = 1;
            deltaY = 0;
        }

        public void UseUp()
        {
            Location = new Vector2(startCenter.X - Sprite.GetWidth() / 2, startCenter.Y - Constant.ItemOffset - Sprite.GetHeight() / 2);
            deltaX = 0;
            deltaY = -1;
        }
    }
}
