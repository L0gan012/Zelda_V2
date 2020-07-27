using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class UsableBoomerang : AbstractUsableMoving
    {
        private Rectangle boomerangPerimeter;
        private bool returning;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UsableItemVsEnemy;

        public UsableBoomerang(IGameObject user)
        {
            User = user;
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenBoomerang();
            InventoryPosition = new Vector2(HUDConstants.BoomerangInventoryPosition.X, HUDConstants.BoomerangInventoryPosition.Y);
            DamageAmount = ItemConstants.BoomerangDamageAmount;

            boomerangPerimeter = new Rectangle((int)user.Center.X - ItemConstants.BoomerangDistance, (int)user.Center.Y - ItemConstants.BoomerangDistance, ItemConstants.BoomerangDistance*2, ItemConstants.BoomerangDistance*2);
            returning = false;
        }

        public override void Update()
        {
            if (boomerangPerimeter.Contains(Center) && !returning)
            {
                Position += Velocity * ItemConstants.BoomerangSpeed;
            }
            //Change to Rectangle.Intersect when collision is put in
            else if ((Convert.ToInt32(Center.X) != Convert.ToInt32(User.Center.X)) || (Convert.ToInt32(Center.Y) != Convert.ToInt32(User.Center.Y)))
            {
                returning = true;

                //With help from https://stackoverflow.com/questions/4248236/drawing-a-path-between-two-points
                Vector2 delta = User.Center - Center;
                float distance = delta.Length();
                Vector2 direction = delta / distance;
                Position += direction * ItemConstants.BoomerangSpeed;
            }
            else
            {
                IsDestructable = true;
            }

            base.Update();
        }
    }
}
