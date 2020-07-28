namespace Sprint2
{
    public static class ObjectStorage
    {
        public static INPC CreateCharObject(string name)
        {
            switch (name)
            {
                case "Aquamentus":
                    return new Aquamentus();
                case "Gel":
                    return new Gel();
                case "Goriya":
                    return new Goriya();
                case "Keese":
                    return new Keese();
                case "SpikeCross":
                    return new SpikeCross();
                case "Stalfos":
                    return new Stalfos();
                case "Zol":
                    return new Zol();
                case "OldMan":
                    return new OldMan();
                case "Wallmaster":
                    return new Wallmaster();
                default:
                    return new Aquamentus();
            }
        }

        public static IBlock CreateBlockObject(string name)
        {
            switch (name)
            {
                case "DownOpenDoor":
                    return new BlockDownOpenDoor();
                case "DownShutDoor":
                    return new BlockDownShutDoor();
                case "DownWall":
                    return new BlockDownWall();
                case "DownLockedDoor":
                    return new BlockDownLockedDoor();
                case "DownBombedDoor":
                    return new BlockDownBombedDoor();
                case "Brick":
                    return new BlockBrick();
                case "Gap":
                    return new BlockGap();
                case "Ladder":
                    return new BlockLadder();
                case "LeftBombedOpening":
                    return new BlockLeftBombedOpening();
                case "LeftLockedDoor":
                    return new BlockLeftLockedDoor();
                case "LeftOpenDoor":
                    return new BlockLeftOpenDoor();
                case "LeftShutDoor":
                    return new BlockLeftShutDoor();
                case "LeftStatue":
                    return new BlockLeftStatue();
                case "LeftWall":
                    return new BlockLeftWall();
                case "RightBombedOpening":
                    return new BlockRightBombedOpening();
                case "RightLockedDoor":
                    return new BlockRightLockedDoor();
                case "RightOpenDoor":
                    return new BlockRightOpenDoor();
                case "RightShutDoor":
                    return new BlockRightShutDoor();
                case "RightStatue":
                    return new BlockRightStatue();
                case "RightWall":
                    return new BlockRightWall();
                case "Square":
                    return new BlockSquare();
                case "UpBombedOpening":
                    return new BlockUpBombedOpening();
                case "UpLockedDoor":
                    return new BlockUpLockedDoor();
                case "UpOpenDoor":
                    return new BlockUpOpenDoor();
                case "UpShutDoor":
                    return new BlockUpShutDoor();
                case "UpWall":
                    return new BlockUpWall();
                case "UpBreakableWall":
                    return new BlockUpBreakableWall();
                case "DownBreakableWall":
                    return new BlockDownBreakableWall();
                case "RightBreakableWall":
                    return new BlockRightBreakableWall();
                case "LeftBreakableWall":
                    return new BlockLeftBreakableWall();
                case "TopRightWall":
                    return new BlockTopRightWall();
                case "BottomRightWall":
                    return new BlockBottomRightWall();
                case "TopLeftWall":
                    return new BlockTopLeftWall();
                case "BottomLeftWall":
                    return new BlockBottomLeftWall();
                case "RightTopWall":
                    return new BlockRightTopWall();
                case "RightBottomWall":
                    return new BlockRightBottomWall();
                case "LeftBottomWall":
                    return new BlockLeftBottomWall();
                case "LeftTopWall":
                    return new BlockLeftTopWall();
                case "FloorTile":
                    return new BlockFloorTile();
                case "BlockTile":
                    return new BlockBlockTile();
                case "BlackTileWalk":
                    return new BlockBlackTileWalk();
                case "BlackTileNoWalk":
                    return new BlockBlackTileNoWalk();
                case "BrickTile":
                    return new BlockBrickTile();
                case "LadderTile":
                    return new BlockLadderTile();
                case "WaterTile":
                    return new BlockWaterTile();
                case "LeftStatueTile":
                    return new BlockLeftStatueTile();
                case "RightStatueTile":
                    return new BlockRightStatueTile();
                case "MovableBlockTile":
                    return new BlockMovableBlockTile();
                case "DownGuideLeft":
                    return new BlockDownGuideLeft();
                case "DownGuideRight":
                    return new BlockDownGuideRight();
                case "UpGuideLeft":
                    return new BlockUpGuideLeft();
                case "UpGuideRight":
                    return new BlockUpGuideRight();
                case "LeftGuideUp":
                    return new BlockLeftGuideUp();
                case "LeftGuideDown":
                    return new BlockLeftGuideDown();
                case "RightGuideUp":
                    return new BlockRightGuideUp();
                case "RightGuideDown":
                    return new BlockRightGuideDown();

                default:
                    return new BlockFloorTile();
            }
        }

        public static IItem CreateItemObject(string name)
        {
            switch (name)
            {
                case "ItemBlueCandle":
                    return new ItemBlueCandle();
                case "ItemBluePotion":
                    return new ItemBluePotion();
                case "ItemBlueRing":
                    return new ItemBlueRing();
                case "ItemBomb":
                    return new ItemBomb();
                case "ItemBow":
                    return new ItemBow();
                case "ItemClock":
                    return new ItemClock();
                case "ItemCompass":
                    return new ItemCompass();
                case "ItemFairy":
                    return new ItemFairy();
                case "ItemFiveRupee":
                    return new ItemFiveRupee();
                case "ItemFlute":
                    return new ItemFlute();
                case "ItemHeartContainer":
                    return new ItemHeartContainer();
                case "ItemKey":
                    return new ItemKey();
                case "ItemLadder":
                    return new ItemLadder();
                case "ItemMagicBoomerang":
                    return new ItemMagicBoomerang();
                case "ItemMagicRod":
                    return new ItemMagicRod();
                case "ItemMagicShield":
                    return new ItemMagicShield();
                case "ItemMap":
                    return new ItemMap();
                case "ItemPotionNote":
                    return new ItemPotionNote();
                case "ItemPowerBracelet":
                    return new ItemPowerBracelet();
                case "ItemRaft":
                    return new ItemRaft();
                case "ItemRupee":
                    return new ItemRupee();
                case "ItemSilverArrow":
                    return new ItemSilverArrow();
                case "ItemTriforcePiece":
                    return new ItemTriforcePiece();
                case "ItemWhiteSword":
                    return new ItemWhiteSword();
                case "ItemWoodenArrow":
                    return new ItemWoodenArrow();
                case "ItemFire":
                    return new ItemFire();
                case "ItemWoodenBoomerang":
                    return new ItemWoodenBoomerang();
                default:
                    return new ItemBlueCandle();
            }
        }

        public static IDoorTrigger CreateDoorTriggerObject(string name)
        {
            switch (name)
            {
                case "UpOverDoor":
                    return new BlockUpOverDoor();
                case "DownOverDoor":
                    return new BlockDownOverDoor();
                case "LeftOverDoor":
                    return new BlockLeftOverDoor();
                case "RightOverDoor":
                    return new BlockRightOverDoor();
                case "UpOverBombed":
                    return new BlockUpOverBombed();
                case "UpOverWall":
                    return new BlockUpOverWall();
                case "DownOverWall":
                    return new BlockDownOverWall();
                case "RightOverWall":
                    return new BlockRightOverWall();
                case "LeftOverWall":
                    return new BlockLeftOverWall();
                case "DownOverBombed":
                    return new BlockDownOverBombed();
                case "LeftOverBombed":
                    return new BlockLeftOverBombed();
                case "RightOverBombed":
                    return new BlockRightOverBombed();
                case "Stairs":
                    return new BlockStairsTile();
                case "ExitTreasureRoomTile":
                    return new BlockDoorTriggerTreasureExit();
                default:
                    return new BlockStairsTile();
            }
        }
    }
}

