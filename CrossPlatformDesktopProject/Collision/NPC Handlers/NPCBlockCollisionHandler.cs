using Microsoft.Xna.Framework;
namespace Sprint2.Collision.NPCHandlers
{
    public static class NPCBlockCollisionHandler
    {
        
        public static void HandleCollision(INPC character, ICollision collision)
        {

            character.Knockback = false;

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
        }

        private static void LeftCollision(INPC character)
        {
        }

        private static void UpCollision(INPC character)
        {
        }

        private static void DownCollision(INPC character)
        {
        }
    }
}
