using Microsoft.Xna.Framework;
using System.Security.Principal;

namespace Sprint2
{
    public class LinkBlockCollisionHandler
    {
        private ILink link;
        private IBlock block;
        private ICollision collision;

        public void HandleCollision(ILink link, IBlock block, ICollision side)
        {
            this.link = link;
            this.block = block;
            collision = side;

            switch (collision.GetSide())
            {
                case Enumerations.CollisionSide.right:
                    RightCollision();
                    break;
                case Enumerations.CollisionSide.left:
                    LeftCollision();
                    break;
                case Enumerations.CollisionSide.up:
                    UpCollision();
                    break;
                case Enumerations.CollisionSide.down:
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
                block.Position += new Vector2(collision.GetCollisionAmount(), 0);
            }
            else
            {
                link.Position -= new Vector2(collision.GetCollisionAmount(), 0);
            }
        }

        private void LeftCollision()
        {
            if (block.IsMovable)
            {
                block.Position -= new Vector2(collision.GetCollisionAmount(), 0);
            }
            else
            {
                link.Position += new Vector2(collision.GetCollisionAmount(), 0);
            }
        }

        private void UpCollision()
        {
            if (block.IsMovable)
            {
                block.Position -= new Vector2(0, collision.GetCollisionAmount());
            }
            else
            {
                link.Position += new Vector2(0, collision.GetCollisionAmount());
            }
        }

        private void DownCollision()
        {
            if (block.IsMovable)
            {
                block.Position += new Vector2(0, collision.GetCollisionAmount());
            }
            else
            {
                link.Position -= new Vector2(0, collision.GetCollisionAmount());
            }
        }
    }
}
