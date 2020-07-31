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
                case "BlockDownOpenDoor":
                    return new BlockDownOpenDoor();
                case "BlockDownShutDoor":
                    return new BlockDownShutDoor();
                case "BlockDownWall":
                    return new BlockDownWall();
                case "BlockDownLockedDoor":
                    return new BlockDownLockedDoor();
                case "BlockDownBombedDoor":
                    return new BlockDownBombedDoor();
                case "BlockBrick":
                    return new BlockBrick();
                case "BlockGap":
                    return new BlockGap();
                case "BlockLadder":
                    return new BlockLadder();
                case "BlockLeftBombedOpening":
                    return new BlockLeftBombedOpening();
                case "BlockLeftLockedDoor":
                    return new BlockLeftLockedDoor();
                case "BlockLeftOpenDoor":
                    return new BlockLeftOpenDoor();
                case "BlockLeftShutDoor":
                    return new BlockLeftShutDoor();
                case "BlockLeftStatue":
                    return new BlockLeftStatue();
                case "BlockLeftWall":
                    return new BlockLeftWall();
                case "BlockRightBombedOpening":
                    return new BlockRightBombedOpening();
                case "BlockRightLockedDoor":
                    return new BlockRightLockedDoor();
                case "BlockRightOpenDoor":
                    return new BlockRightOpenDoor();
                case "BlockRightShutDoor":
                    return new BlockRightShutDoor();
                case "BlockRightStatue":
                    return new BlockRightStatue();
                case "BlockRightWall":
                    return new BlockRightWall();
                case "BlockSquare":
                    return new BlockSquare();
                case "BlockUpBombedOpening":
                    return new BlockUpBombedOpening();
                case "BlockUpLockedDoor":
                    return new BlockUpLockedDoor();
                case "BlockUpOpenDoor":
                    return new BlockUpOpenDoor();
                case "BlockUpShutDoor":
                    return new BlockUpShutDoor();
                case "BlockUpWall":
                    return new BlockUpWall();
                case "BlockUpBreakableWall":
                    return new BlockUpBreakableWall();
                case "BlockDownBreakableWall":
                    return new BlockDownBreakableWall();
                case "BlockRightBreakableWall":
                    return new BlockRightBreakableWall();
                case "BlockLeftBreakableWall":
                    return new BlockLeftBreakableWall();
                case "BlockTopRightWall":
                    return new BlockTopRightWall();
                case "BlockBottomRightWall":
                    return new BlockBottomRightWall();
                case "BlockTopLeftWall":
                    return new BlockTopLeftWall();
                case "BlockBottomLeftWall":
                    return new BlockBottomLeftWall();
                case "BlockRightTopWall":
                    return new BlockRightTopWall();
                case "BlockRightBottomWall":
                    return new BlockRightBottomWall();
                case "BlockLeftBottomWall":
                    return new BlockLeftBottomWall();
                case "BlockLeftTopWall":
                    return new BlockLeftTopWall();
                case "BlockFloorTile":
                    return new BlockFloorTile();
                case "BlockBlockTile":
                    return new BlockBlockTile();
                case "BlockBlackTileWalk":
                    return new BlockBlackTileWalk();
                case "BlockBlackTileNoWalk":
                    return new BlockBlackTileNoWalk();
                case "BlockBrickTile":
                    return new BlockBrickTile();
                case "BlockLadderTile":
                    return new BlockLadderTile();
                case "BlockWaterTile":
                    return new BlockWaterTile();
                case "BlockLeftStatueTile":
                    return new BlockLeftStatueTile();
                case "BlockRightStatueTile":
                    return new BlockRightStatueTile();
                case "BlockMovableBlockTile":
                    return new BlockMovableBlockTile();
                case "BlockDownGuideLeft":
                    return new BlockDownGuideLeft();
                case "BlockDownGuideRight":
                    return new BlockDownGuideRight();
                case "BlockUpGuideLeft":
                    return new BlockUpGuideLeft();
                case "BlockUpGuideRight":
                    return new BlockUpGuideRight();
                case "BlockLeftGuideUp":
                    return new BlockLeftGuideUp();
                case "BlockLeftGuideDown":
                    return new BlockLeftGuideDown();
                case "BlockRightGuideUp":
                    return new BlockRightGuideUp();
                case "BlockRightGuideDown":
                    return new BlockRightGuideDown();
                case "BlockUpLockedDoorStop":
                    return new BlockUpLockedDoorStop();
                case "BlockDownLockedDoorStop":
                    return new BlockDownLockedDoorStop();
                case "BlockLeftLockedDoorStop":
                    return new BlockLeftLockedDoorStop();
                case "BlockRightLockedDoorStop":
                    return new BlockRightLockedDoorStop();
                case "BlockUpSealedDoorStop":
                    return new BlockUpSealedDoorStop();
                case "BlockLeftSealedDoorStop":
                    return new BlockLeftSealedDoorStop();
                case "BlockRightSealedDoorStop":
                    return new BlockRightSealedDoorStop();
                case "BlockDownSealedDoorStop":
                    return new BlockDownSealedDoorStop();
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
                case "BlockUpOverDoor":
                    return new BlockUpOverDoor();
                case "BlockDownOverDoor":
                    return new BlockDownOverDoor();
                case "BlockLeftOverDoor":
                    return new BlockLeftOverDoor();
                case "BlockRightOverDoor":
                    return new BlockRightOverDoor();
                case "BlockUpOverBombed":
                    return new BlockUpOverBombed();
                case "BlockUpOverWall":
                    return new BlockUpOverWall();
                case "BlockDownOverWall":
                    return new BlockDownOverWall();
                case "BlockRightOverWall":
                    return new BlockRightOverWall();
                case "BlockLeftOverWall":
                    return new BlockLeftOverWall();
                case "BlockDownOverBombed":
                    return new BlockDownOverBombed();
                case "BlockLeftOverBombed":
                    return new BlockLeftOverBombed();
                case "BlockRightOverBombed":
                    return new BlockRightOverBombed();
                case "BlockStairsTile":
                    return new BlockStairsTile();
                case "BlockDoorTriggerTreasureExit":
                    return new BlockDoorTriggerTreasureExit();
                default:
                    return new BlockStairsTile();
            }
        }
    }
}

