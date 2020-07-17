namespace Sprint2
{
    public static class NPCBlockCollisionHandler
    {
        public static void HandleCollision(INPC character, IBlock block, Enumerations.CollisionSide collisionSide)
        {
            character.Knockback = false;
            character.HasHitWall = true;
        }
    }
}
