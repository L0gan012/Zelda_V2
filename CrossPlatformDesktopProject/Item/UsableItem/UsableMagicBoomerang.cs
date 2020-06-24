using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class UsableMagicBoomerang : AbstractUsableMoving
    {
        private Rectangle boomerangPerimeter;
        private bool returning;

        public UsableMagicBoomerang(ILink link)
        {
            Link = link;
            boomerangPerimeter = new Rectangle(Constant.DungeonWallWidth, Constant.DungeonWallHeight, Constant.ScreenWidth - (2 * Constant.DungeonWallWidth), Constant.ScreenHeight - (2 * Constant.DungeonWallHeight));
            returning = false;

            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileMagicBoomerang();
            Color = Color.White;
        }

        public override void Update()
        {
            if (boomerangPerimeter.Contains(Center) && !returning)
            {
                Location = new Vector2(Location.X + DeltaX * Constant.BoomerangSpeed, Location.Y + DeltaY * Constant.BoomerangSpeed);
            }
            //Change to Rectangle.Interset when collision is put in
            else if ((Convert.ToInt32(Center.X) != Convert.ToInt32(Link.Center.X)) || (Convert.ToInt32(Center.Y) != Convert.ToInt32(Link.Center.Y)))
            {
                returning = true;
                
                //With help from https://stackoverflow.com/questions/4248236/drawing-a-path-between-two-points
                Vector2 delta = Link.Center - Center;
                float distance = delta.Length();
                Vector2 direction = delta / distance;
                Location += direction * Constant.BoomerangSpeed;
            }
            else
            {
                Link.SecondaryItem = null;
            }

            base.Update();
        }
    }
}
