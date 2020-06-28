using Microsoft.Xna.Framework;
namespace Sprint2
{
    public class NPCUsableItemCollisionHandler
    {
        public static void HandleCollision(INPC character, IUsableItem item, ICollision collision)
        {
            character.TakeDamage(item.DamageAmount);

            switch (collision.Side)
            {
                case Enumerations.Sides.right:
                    RightCollision(character);
                    break;
                case Enumerations.Sides.left:
                    LeftCollision(character);
                    break;
                case Enumerations.Sides.up:
                    UpCollision(character);
                    break;
                case Enumerations.Sides.down:
                    DownCollision(character);
                    break;
                default:
                    break;
            }

        }

        private static void RightCollision(INPC character)
        {
            character.Velocity = Vector2.UnitX * Constant.NPCKnockbackSpeed;
        }

        private static void LeftCollision(INPC character)
        {
            character.Velocity = -Vector2.UnitX * Constant.NPCKnockbackSpeed;
        }

        private static void UpCollision(INPC character)
        {
            character.Velocity = -Vector2.UnitY * Constant.NPCKnockbackSpeed;
        }

        private static void DownCollision(INPC character)
        {
            character.Velocity = Vector2.UnitY * Constant.NPCKnockbackSpeed;
        }
    }
}
