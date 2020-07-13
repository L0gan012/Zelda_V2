﻿using System.Globalization;

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
            EnemyAquamentus,
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
            ItemTriforcePiece,
            ItemHeartContainer,
            Fire
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

        public enum Direction { Up, Down, Right, Left }
    }
}
