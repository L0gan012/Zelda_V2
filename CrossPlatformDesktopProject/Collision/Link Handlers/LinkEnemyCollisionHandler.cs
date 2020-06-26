using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkEnemyCollisionHandler
    {
        private ILink link;

        public void HandleCollision(ILink link, INPC enemy, ICollision side)
        {
            this.link = link;
            //Pass enemy to damage method to determine how much health to remove?
            link.DamagePlayer();

            switch (side.GetSide())
            {
                case Enumerations.CollisionSide.left:
                    LeftCollision();
                    break;
                case Enumerations.CollisionSide.right:
                    RightCollision();
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

        private void LeftCollision()
        {
            link.Position += new Vector2(Constant.LinkKnockback, 0);
        }

        private void RightCollision()
        {
            link.Position -= new Vector2(Constant.LinkKnockback, 0);
        }

        private void UpCollision()
        {
            link.Position += new Vector2(0, Constant.LinkKnockback);
        }

        private void DownCollision()
        {
            link.Position -= new Vector2(0, Constant.LinkKnockback);
        }
    }
}
