using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class NPCUsableItemCollisionHandler
    {
        public static void HandleCollision(INPC character, IUsableItem item, Enumerations.CollisionSide collisionSide)
        {
            character.TakeDamage(item.DamageAmount);
            item.IsDestructable = true;

            switch (collisionSide)
            {
                case Enumerations.CollisionSide.Right:
                    RightCollision(character);
                    break;
                case Enumerations.CollisionSide.Left:
                    LeftCollision(character);
                    break;
                case Enumerations.CollisionSide.Top:
                    UpCollision(character);
                    break;
                case Enumerations.CollisionSide.Bottom:
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
