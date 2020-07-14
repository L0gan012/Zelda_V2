using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
                case "Old Man":
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
                case "DownShutDoor":
                    return new BlockDownShutDoor();
                case "DownWall":
                    return new BlockDownWall();
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
                case "Stairs":
                    return new BlockStairs();
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
                default:
                    return new BlockLeftStatue();
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
                default:
                    return new ItemBlueCandle();


            }
        }
        public static IBackground CreateBackgroundObject(string name)
            {
                switch (name)
                {
                    case "BackgroundOne":
                        return new BackgroundOne();
                    case "BackgroundTwo":
                        return new BackgroundTwo();
                    case "BackgroundThree":
                        return new BackgroundThree();
                    case "BackgroundFour":
                        return new BackgroundFour();
                    case "BackgroundFive":
                        return new BackgroundFive();
                    case "BackgroundSix":
                        return new BackgroundSix();
                    case "BackgroundSeven":
                        return new BackgroundSeven();
                    case "BackgroundEight":
                        return new BackgroundEight();
                    case "BackgroundNine":
                        return new BackgroundNine();
                    case "BackgroundTen":
                        return new BackgroundTen();
                    case "BackgroundEleven":
                        return new BackgroundEleven();
                    case "BackgroundTwelve":
                        return new BackgroundTwelve();
                    case "BackgroundThirteen":
                        return new BackgroundThirteen();
                    case "BackgroundFourteen":
                        return new BackgroundFourteen();
                    case "BackgroundFifteen":
                        return new BackgroundFifteen();
                    case "BackgroundSixteen":
                        return new BackgroundSixteen();
                    case "BackgroundSeventeen":
                        return new BackgroundSeventeen();
                    case "BackgroundEighteen":
                        return new BackgroundEighteen();
                    default:
                        return new BackgroundOne();
                }
            }
        }
    }

