using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkBlockCollisionHandler
    {
        private ILink link;
        private IBlock block;

        public void HandleCollision(ILink link, IBlock block, ICollision side)
        {
            this.link = link;
            this.block = block;

            switch (side.GetSide())
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
                block.Position = new Vector2(block.Position.X + 1, block.Position.Y);
            }
            else
            {
                link.Position = new Vector2(link.Position.X - 1, link.Position.Y);
            }
        }

        private void LeftCollision()
        {
            if (block.IsMovable)
            {
                block.Position = new Vector2(block.Position.X - 1, block.Position.Y);
            }
            else
            {
                link.Position = new Vector2(link.Position.X + 1, link.Position.Y);
            }
        }

        private void UpCollision()
        {
            if (block.IsMovable)
            {
                block.Position = new Vector2(block.Position.X, block.Position.Y - 1);
            }
            else
            {
                link.Position = new Vector2(link.Position.X, link.Position.Y + 1);
            }
        }

        private void DownCollision()
        {
            if (block.IsMovable)
            {
                block.Position = new Vector2(block.Position.X, block.Position.Y + 1);
            }
            else
            {
                link.Position = new Vector2(link.Position.X, link.Position.Y - 1);
            }
        }
    }
}
