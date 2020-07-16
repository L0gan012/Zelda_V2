using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkProjectileCollisionHandler
    {
        public static void HandleCollision(ILink link, IProjectile projectile, Enumerations.CollisionSide collisionSide)
        {
            Contract.Requires(link != null);
            Contract.Requires(projectile != null);
            //Contract.Requires(collision != null);

            link.DamagePlayer(projectile.DamageAmount);
            SoundManager.Instance.PlayLinkHit();
            link.Knockback = true;
            link.CollisionLocation = link.Position;

            switch (collisionSide)
            {
                case Enumerations.CollisionSide.Left:
                    LeftCollision(link);
                    break;
                case Enumerations.CollisionSide.Right:
                    RightCollision(link);
                    break;
                case Enumerations.CollisionSide.Top:
                    UpCollision(link);
                    break;
                case Enumerations.CollisionSide.Bottom:
                    DownCollision(link);
                    break;
                default:
                    break;
            }
        }

        private static void LeftCollision(ILink link)
        {
            link.Velocity = Vector2.UnitX * Constant.LinkKnockbackSpeed;
        }

        private static void RightCollision(ILink link)
        {
            link.Velocity = -Vector2.UnitX * Constant.LinkKnockbackSpeed;
        }

        private static void UpCollision(ILink link)
        {
            link.Velocity = Vector2.UnitY * Constant.LinkKnockbackSpeed;
        }

        private static void DownCollision(ILink link)
        {
            link.Velocity = -Vector2.UnitY * Constant.LinkKnockbackSpeed;
        }
    }
}
