using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class LinkBlockCollisionHandler
    {
        public static void HandleCollision(ILink link, IBlock block, Enumerations.CollisionSide collisionSide)
        {
            Contract.Requires(link != null);
            Contract.Requires(block != null);
           // Contract.Requires(collisionSide != null);

            if (block.IsMovable)
            {
                block.Knockback = true;
                block.CollisionLocation = block.Position;

                switch (collisionSide)
                {
                    case Enumerations.CollisionSide.Right:
                        RightCollision(block, link);
                        break;
                    case Enumerations.CollisionSide.Left:
                        LeftCollision(block, link);
                        break;
                    case Enumerations.CollisionSide.Top:
                        UpCollision(block, link);
                        break;
                    case Enumerations.CollisionSide.Bottom:
                        DownCollision(block, link);
                        break;
                    default:
                        break;
                }
            }
            link.Knockback = false;
        }

        private static void RightCollision(IBlock block, ILink link)
        {
            block.Velocity = Vector2.UnitX * Constant.BlockMovementSpeed;
        }

        private static void LeftCollision(IBlock block, ILink link)
        {
            block.Velocity = -Vector2.UnitX * Constant.BlockMovementSpeed;
        }

        private static void UpCollision(IBlock block, ILink link)
        {
            block.Velocity = -Vector2.UnitY * Constant.BlockMovementSpeed;
        }

        private static void DownCollision(IBlock block, ILink link)
        {
            block.Velocity = Vector2.UnitY * Constant.BlockMovementSpeed;
        }
    }
}
