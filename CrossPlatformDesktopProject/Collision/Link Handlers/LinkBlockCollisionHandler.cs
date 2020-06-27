using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkBlockCollisionHandler
    {
        private ILink link;
        private IBlock block;
        private ICollision collision;

        public void HandleCollision(ILink link, IBlock block, ICollision collision)
        {
            this.link = link;
            this.block = block;
            this.collision = collision;

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
                block.Position += new Vector2(collision.CollisionAmount, 0);
            }
            else
            {
                link.Position -= new Vector2(collision.CollisionAmount, 0);
            }
        }

        private void LeftCollision()
        {
            if (block.IsMovable)
            {
                block.Position -= new Vector2(collision.CollisionAmount, 0);
            }
            else
            {
                link.Position += new Vector2(collision.CollisionAmount, 0);
            }
        }

        private void UpCollision()
        {
            if (block.IsMovable)
            {
                block.Position -= new Vector2(0, collision.CollisionAmount);
            }
            else
            {
                link.Position += new Vector2(0, collision.CollisionAmount);
            }
        }

        private void DownCollision()
        {
            if (block.IsMovable)
            {
                block.Position += new Vector2(0, collision.CollisionAmount);
            }
            else
            {
                link.Position -= new Vector2(0, collision.CollisionAmount);
            }
        }
    }
}
