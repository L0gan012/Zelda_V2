using Microsoft.Xna.Framework;
namespace Sprint2
{
    public class NPCUsableItemCollisionHandler
    {
        private INPC character;
        private IUsableItem item;
        private ICollision collision;

        public void HandleCollision(INPC character, IUsableItem item, ICollision side)
        {
            this.character = character;
            this.item = item;
            collision = side;

            character.TakeDamage(this.item.DamageAmount);

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
            character.Position -= new Vector2(collision.CollisionAmount + Constant.EnemyKnockback, 0);
        }

        private void LeftCollision()
        {

            character.Position += new Vector2(collision.CollisionAmount + Constant.EnemyKnockback, 0);
        }

        private void UpCollision()
        {
            character.Position += new Vector2(0, collision.CollisionAmount + Constant.EnemyKnockback);
        }

        private void DownCollision()
        {
            character.Position -= new Vector2(0, collision.CollisionAmount + Constant.EnemyKnockback);
        }
    }
}
