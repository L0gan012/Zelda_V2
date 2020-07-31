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
            EnemyAquamentus,
            ProjectileVsPlayer,
            ProjectileVsEnemy,
            ProjectileVsAll,
            UsableItemVsEnemy,
            UsableItemVsPlayer,
            UsableItemVsAll,
            UsableItemSwordBeam,
            Block,
            ItemInstant,
            ItemBomb,
            ItemEquipment,
            ItemEquipmentBow,
            ItemKey,
            ItemTriforcePiece,
            ItemHeartContainer,
            ItemHeart,
            ItemRupee,
            ItemFiveRupee,
            ItemUsableBomb,
            UsableItemBomb,
            Fire,
            DoorLeft,
            DoorRight,
            DoorDown,
            DoorUp,
            FloorTile,
            StairsTile,
            OverDoor,
            MovableBlock,
            DownGuideRight,
            DownGuideLeft,
            UpGuideRight,
            UpGuideLeft,
            RightGuideUp,
            RightGuideDown,
            LeftGuideUp,
            LeftGuideDown,
            DoorTriggerUp,
            DoorTriggerDown,
            DoorTriggerLeft,
            DoorTriggerRight,
            DoorTriggerExitTreasureRoom,
            StairsTrigger,
            UpBreakableWall,
            DownBreakableWall,
            LeftBreakableWall,
            RightBreakableWall,
            DoorBlocker,
            DownLockStop,
            RightLockStop,
            LeftLockStop,
            UpLockStop,
            DownSealStop,
            RightSealStop,
            LeftSealStop,
            UpSealStop
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

        public enum DoorType { Sealed, Locked, Bombed }
    }
}
