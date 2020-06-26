namespace Sprint2
{
    public static class Enumerations
    {
        public enum GameObjectType
        {
            Player,
            Wall,
            WallBreakable,
            EnemyFlying,
            EnemyGround,
            ProjectileVsPlayer,
            ProjectileVsEnemy,
            ProjectileVsAll,

        }

        public enum ArrowType { wooden, silver }

        public enum CollisionSide { right, left, up, down }
    }
}
