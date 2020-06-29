using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class BlockUsableItemCollisionHandler
    {
        public static void HandleCollision(IUsableItem item, IBlock block, Enumerations.CollisionSide collision)
        {
            Contract.Requires(block != null);
            Contract.Requires(item != null);

            if (block.IsMovable)
            {
                block.Knockback = true;
                block.CollisionLocation = block.Position;

                switch (collision)
                {
                    case Enumerations.CollisionSide.Right:
                        RightCollision(block);
                        break;
                    case Enumerations.CollisionSide.Left:
                        LeftCollision(block);
                        break;
                    case Enumerations.CollisionSide.Top:
                        UpCollision(block);
                        break;
                    case Enumerations.CollisionSide.Bottom:
                        DownCollision(block);
                        break;
                    default:
                        break;
                }
            }
            block.Knockback = false;
        }

        private static void RightCollision(IBlock block)
        {
            block.Velocity = Vector2.UnitX * Constant.BlockMovementSpeed;
        }

        private static void LeftCollision(IBlock block)
        {
            block.Velocity = -Vector2.UnitX * Constant.BlockMovementSpeed;
        }

        private static void UpCollision(IBlock block)
        {
            block.Velocity = -Vector2.UnitY * Constant.BlockMovementSpeed;
        }

        private static void DownCollision(IBlock block)
        {
            block.Velocity = Vector2.UnitY * Constant.BlockMovementSpeed;
        }
    }
}
