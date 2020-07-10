namespace Sprint2
{
    public static class NPCBlockCollisionHandler
    {
        public static void HandleCollision(INPC character, IBlock block, Enumerations.CollisionSide collisionSide)
        {
            character.Knockback = false;

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
