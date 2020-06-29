using Microsoft.Xna.Framework;
using System.Diagnostics.Contracts;

namespace Sprint2
{
    public static class BlockBlockCollisionHandler
    {
        public static void HandleCollision(IBlock blockOne, IBlock blockTwo, Enumerations.CollisionSide collision)
        {
            Contract.Requires(blockOne != null);
            Contract.Requires(blockTwo != null);

            if (blockOne.IsMovable)
            {
                blockOne.Knockback = true;
                blockOne.CollisionLocation = blockOne.Position;

                switch (collision)
                {

                    case Enumerations.CollisionSide.Right:
                        RightCollision(blockOne);
                        break;
                    case Enumerations.CollisionSide.Left:
                        LeftCollision(blockOne);
                        break;
                    case Enumerations.CollisionSide.Top:
                        UpCollision(blockOne);
                        break;
                    case Enumerations.CollisionSide.Bottom:
                        DownCollision(blockOne);
                        break;
                    default:
                        break;
                }
            }
            blockTwo.Knockback = false;
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
