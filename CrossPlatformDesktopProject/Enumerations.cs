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
            UsableItemVsEnemy,
            UsableItemVsPlayer,
            UsableItemVsAll,
            Block,
            ItemInstant,
            ItemEquipment

        }

        public enum ArrowType { wooden, silver }

        public enum CollisionSide
        {
            Top,
            Bottom,
            Right,
            Left,
            None
        }

        public enum Sides { right, left, up, down }
    }
}
