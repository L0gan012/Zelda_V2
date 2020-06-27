using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkProjectileCollisionHandler
    {
        public static void HandleCollision(ILink link, IUsableItem projectile, ICollision collision)
        {
            Contract.Requires(link != null);
            Contract.Requires(projectile != null);
            Contract.Requires(collision != null);

            switch (collision.Side)
            {
                case Enumerations.Sides.right:
                    RightCollision(link, projectile, collision);
                    break;
                case Enumerations.Sides.left:
                    LeftCollision(link, projectile, collision);
                    break;
                case Enumerations.Sides.up:
                    UpCollision(link, projectile, collision);
                    break;
                case Enumerations.Sides.down:
                    DownCollision(link, projectile, collision);
                    break;
                default:
                    break;
            }
        }

        private static void LeftCollision(ILink link, IUsableItem projectile, ICollision collision)
        {
            if (link.FacingDirection.Equals(collision.Side))
            {
                projectile.Knockback = true;
                projectile.CollisionLocation = projectile.Position;
                projectile.Velocity = -Vector2.UnitX * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Knockback = true;
                link.Velocity = Vector2.UnitX * Constant.LinkKnockbackSpeed;
            }
        }

        private static void RightCollision(ILink link, IUsableItem projectile, ICollision collision)
        {
            if (link.FacingDirection.Equals(collision.Side))
            {
                projectile.Velocity = Vector2.UnitX * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = -Vector2.UnitX * Constant.LinkKnockbackSpeed;
            }
        }

        private static void UpCollision(ILink link, IUsableItem projectile, ICollision collision)
        {
            if (link.FacingDirection.Equals(collision.Side))
            {
                projectile.Velocity = -Vector2.UnitY * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = Vector2.UnitY * Constant.LinkKnockbackSpeed;
            }
        }

        private static void DownCollision(ILink link, IUsableItem projectile, ICollision collision)
        {
            if (link.FacingDirection.Equals(collision.Side))
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
