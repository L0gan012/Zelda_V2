using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkProjectileCollisionHandler
    {
        public static void HandleCollision(ILink link, IUsableItem projectile, Enumerations.CollisionSide collisionSide)
        {
            Contract.Requires(link != null);
            Contract.Requires(projectile != null);
            //Contract.Requires(collision != null);

            projectile.IsDestructable = true;

            if (link.FacingDirection.Equals(collisionSide))
            {
                projectile.Knockback = true;
                projectile.CollisionLocation = projectile.Position;
            }
            else
            {
                link.Knockback = true;
                link.CollisionLocation = link.Position;
            }

            switch (collisionSide)
            {
                case Enumerations.CollisionSide.Right:
                    RightCollision(link, projectile, collisionSide);
                    break;
                case Enumerations.CollisionSide.Left:
                    LeftCollision(link, projectile, collisionSide);
                    break;
                case Enumerations.CollisionSide.Top:
                    UpCollision(link, projectile, collisionSide);
                    break;
                case Enumerations.CollisionSide.Bottom:
                    DownCollision(link, projectile, collisionSide);
                    break;
                default:
                    break;
            }
        }

        private static void LeftCollision(ILink link, IUsableItem projectile, Enumerations.CollisionSide collisionSide)
        {
            if (link.FacingDirection.Equals(collisionSide))
            {
                projectile.Velocity = -Vector2.UnitX * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = Vector2.UnitX * Constant.LinkKnockbackSpeed;
            }
        }

        private static void RightCollision(ILink link, IUsableItem projectile, Enumerations.CollisionSide collisionSide)
        {
            if (link.FacingDirection.Equals(collisionSide))
            {
                projectile.Velocity = Vector2.UnitX * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = -Vector2.UnitX * Constant.LinkKnockbackSpeed;
            }
        }

        private static void UpCollision(ILink link, IUsableItem projectile, Enumerations.CollisionSide collisionSide)
        {
            if (link.FacingDirection.Equals(collisionSide))
            {
                projectile.Velocity = -Vector2.UnitY * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = Vector2.UnitY * Constant.LinkKnockbackSpeed;
            }
        }

        private static void DownCollision(ILink link, IUsableItem projectile, Enumerations.CollisionSide collisionSide)
        {
            if (link.FacingDirection.Equals(collisionSide))
            {
                projectile.Velocity = Vector2.UnitY * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = -Vector2.UnitY * Constant.LinkKnockbackSpeed;
            }
        }
    }
}
