using Microsoft.Xna.Framework;

namespace Sprint2
{
    public static class LinkBlockCollisionHandler
    {
        public static void HandleCollision(ILink link, IBlock block, ICollision collision)
        {
            switch (collision.Side)
            {
                case Enumerations.Sides.right:
                    RightCollision(block);
                    break;
                case Enumerations.Sides.left:
                    LeftCollision(block);
                    break;
                case Enumerations.Sides.up:
                    UpCollision(block);
                    break;
                case Enumerations.Sides.down:
                    DownCollision(block);
                    break;
                default:
                    break;
            }
        }

        private static void RightCollision(IBlock block)
        {
            if (block.IsMovable)
            {
                block.Velocity = Vector2.UnitX * Constant.BlockMovementSpeed;
            }
        }

        private static void LeftCollision(IBlock block)
        {
            if (block.IsMovable)
            {
                block.Velocity = -Vector2.UnitX * Constant.BlockMovementSpeed;
            }
        }

        private static void UpCollision(IBlock block)
        {
            if (block.IsMovable)
            {
                block.Velocity = -Vector2.UnitY * Constant.BlockMovementSpeed;
            }
        }

        private static void DownCollision(IBlock block)
        {
            if (block.IsMovable)
            {
                block.Velocity = Vector2.UnitY * Constant.BlockMovementSpeed;
            }
        }
    }
}
