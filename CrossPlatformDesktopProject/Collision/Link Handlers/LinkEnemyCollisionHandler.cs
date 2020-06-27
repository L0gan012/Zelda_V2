using Microsoft.Xna.Framework;

namespace Sprint2
{
    public static class LinkEnemyCollisionHandler
    {
        public static void HandleCollision(ILink link, INPC enemy, ICollision collision)
        {
            link.DamagePlayer(enemy.DamageAmount);

            switch (collision.Side)
            {
                case Enumerations.Sides.left:
                    LeftCollision(link);
                    break;
                case Enumerations.Sides.right:
                    RightCollision(link);
                    break;
                case Enumerations.Sides.up:
                    UpCollision(link);
                    break;
                case Enumerations.Sides.down:
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
