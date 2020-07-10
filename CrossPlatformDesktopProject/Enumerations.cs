using System.Globalization;

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
            ItemEquipment,
            ItemKey,
            ItemTriforcePiece
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

        public enum Direction { up, down, right, left }
    }
}
