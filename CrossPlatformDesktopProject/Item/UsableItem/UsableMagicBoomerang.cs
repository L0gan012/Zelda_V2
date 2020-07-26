using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class UsableMagicBoomerang : AbstractUsableMoving
    {
        private Rectangle boomerangPerimeter;
        private bool returning;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UsableItemVsEnemy;

        public UsableMagicBoomerang(IGameObject user)
        {
            User = user;
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileMagicBoomerang();
            InventoryPosition = Constant.BoomerangInventoryPosition;
            DamageAmount = Constant.BoomerangDamageAmount;

            boomerangPerimeter = new Rectangle((int)Constant.DungeonWallWidth, (int)Constant.DungeonWallHeight, (int)(Constant.ScreenWidth - (2 * Constant.DungeonWallWidth)), (int)(Constant.ScreenHeight - (2 * Constant.DungeonWallHeight)));
            returning = false;
        }

        public override void Update()
        {
            if (boomerangPerimeter.Contains(Center) && !returning)
            {
                Position += Velocity * Constant.BoomerangSpeed;
            }
            //Change to Rectangle.Interset when collision is put in
            else if ((Convert.ToInt32(Center.X) != Convert.ToInt32(User.Center.X)) || (Convert.ToInt32(Center.Y) != Convert.ToInt32(User.Center.Y)))
            {
                returning = true;
                
                //With help from https://stackoverflow.com/questions/4248236/drawing-a-path-between-two-points
                Vector2 delta = User.Center - Center;
                float distance = delta.Length();
                Vector2 direction = delta / distance;
                Position += direction * Constant.BoomerangSpeed;
            }
            else
            {
                IsDestructable = true;
            }

            base.Update();
        }
    }
}
