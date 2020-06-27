using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkBlockCollisionHandler
    {
        private IBlock block;

        public void HandleCollision(ILink link, IBlock block, ICollision collision)
        {
            this.block = block;

            switch (collision.Side)
            {
                case Enumerations.Sides.right:
                    RightCollision();
                    break;
                case Enumerations.Sides.left:
                    LeftCollision();
                    break;
                case Enumerations.Sides.up:
                    UpCollision();
                    break;
                case Enumerations.Sides.down:
                    DownCollision();
                    break;
                default:
                    break;
            }
        }

        private void RightCollision()
        {
            if (block.IsMovable)
            {
                block.Velocity = Vector2.UnitX * Constant.BlockMovementSpeed;
            }
        }

        private void LeftCollision()
        {
            if (block.IsMovable)
            {
                block.Velocity = -Vector2.UnitX * Constant.BlockMovementSpeed;
            }
        }

        private void UpCollision()
        {
            if (block.IsMovable)
            {
                block.Velocity = -Vector2.UnitY * Constant.BlockMovementSpeed;
            }
        }

        private void DownCollision()
        {
            if (block.IsMovable)
            {
                block.Velocity = Vector2.UnitY * Constant.BlockMovementSpeed;
            }
        }
    }
}
