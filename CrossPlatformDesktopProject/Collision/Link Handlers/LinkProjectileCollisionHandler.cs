using Microsoft.Xna.Framework;

namespace Sprint2
{
    public static class LinkProjectileCollisionHandler
    {
        public static void HandleCollision(ILink link, IUsableItem item, ICollision collision)
        {
            switch (collision.Side)
            {
                case Enumerations.Sides.right:
                    RightCollision(link, item, collision);
                    break;
                case Enumerations.Sides.left:
                    LeftCollision(link, item, collision);
                    break;
                case Enumerations.Sides.up:
                    UpCollision(link, item, collision);
                    break;
                case Enumerations.Sides.down:
                    DownCollision(link, item, collision);
                    break;
                default:
                    break;
            }
        }

        private static void LeftCollision(ILink link, IUsableItem item, ICollision collision)
        {
            if (link.FacingDirection.Equals(collision.Side))
            {
                item.Velocity = -Vector2.UnitX * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = Vector2.UnitX * Constant.LinkKnockbackSpeed;
            }
        }

        private static void RightCollision(ILink link, IUsableItem item, ICollision collision)
        {
            if (link.FacingDirection.Equals(collision.Side))
            {
                item.Velocity = Vector2.UnitX * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = -Vector2.UnitX * Constant.LinkKnockbackSpeed;
            }
        }

        private static void UpCollision(ILink link, IUsableItem item, ICollision collision)
        {
            if (link.FacingDirection.Equals(collision.Side))
            {
                item.Velocity = -Vector2.UnitY * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = Vector2.UnitY * Constant.LinkKnockbackSpeed;
            }
        }

        private static void DownCollision(ILink link, IUsableItem item, ICollision collision)
        {
            if (link.FacingDirection.Equals(collision.Side))
            {
                item.Velocity = Vector2.UnitY * Constant.ItemKnockbackSpeed;
            }
            else
            {
                link.Velocity = -Vector2.UnitY * Constant.LinkKnockbackSpeed;
            }
        }
    }
}
