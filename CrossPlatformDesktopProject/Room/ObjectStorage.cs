﻿using Sprint2.Block;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Room
{
    public static class ObjectStorage
    {
        public static Dictionary<String, IBlock> blockObjectType = new Dictionary<string, IBlock>();
        public static Dictionary<String, IItem> itemObjectType = new Dictionary<string, IItem>();
        public static Dictionary<String, INPC> charObjectType = new Dictionary<string, INPC>();
        public static Dictionary<String, IBackground> backgroundObjectType = new Dictionary<string, IBackground>();

        public static INPC createCharObject(string name)
        {
            switch (name)
            {
                case "Aquamentus":
                    return new Aquamentus();
                case "Dodongo":
                    return new Dodongo();
                case "Gel":
                    return new Gel();
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
                default:
                    return new Aquamentus();
            }
        }

        public static IBlock createBlockObject(string name)
        {
            switch (name)
            {
                case "DownShutDoor":
                    return new BlockDownShutDoor();
                case "DownWall":
                    return new BlockDownWall();
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
                default:
                    return new BlockLeftStatue();
            }
        }

        public static void storeItemObject()
        {
            itemObjectType.Add("ItemBlueCandle", new ItemBlueCandle());
            itemObjectType.Add("ItemBluePotion", new ItemBluePotion());
            itemObjectType.Add("ItemBlueRing", new ItemBlueRing());
            itemObjectType.Add("ItemBomb", new ItemBomb());
            itemObjectType.Add("ItemBow", new ItemBow());
            itemObjectType.Add("ItemClock", new ItemClock());
            itemObjectType.Add("ItemCompass", new ItemCompass());
            itemObjectType.Add("ItemFairy", new ItemFairy());
            itemObjectType.Add("ItemFiveRupee", new ItemFiveRupee());
            itemObjectType.Add("ItemFlute", new ItemFlute());
            itemObjectType.Add("ItemHeartContainer", new ItemHeartContainer());
            itemObjectType.Add("ItemKey", new ItemKey());
            itemObjectType.Add("ItemLadder", new ItemLadder());
            itemObjectType.Add("ItemMagicBoomerang", new ItemMagicBoomerang());
            itemObjectType.Add("ItemMagicRod", new ItemMagicRod());
            itemObjectType.Add("ItemMagicShield", new ItemMagicShield());
            itemObjectType.Add("ItemMap", new ItemMap());
            itemObjectType.Add("ItemPotionNote", new ItemPotionNote());
            itemObjectType.Add("ItemPowerBracelet", new ItemPowerBracelet());
            itemObjectType.Add("ItemRaft", new ItemRaft());
            itemObjectType.Add("ItemRupee", new ItemRupee());
            itemObjectType.Add("ItemSilverArrow", new ItemSilverArrow());
            itemObjectType.Add("ItemTriforcePiece", new ItemTriforcePiece());
            itemObjectType.Add("ItemWhiteSword", new ItemWhiteSword());
            itemObjectType.Add("ItemWoodenArrow", new ItemWoodenArrow());
            //itemObjectType.Add("ItemWoodenBoomerang", new ItemWoodenBoomerang());
            //itemObjectType.Add("ItemWoodenSword", new ItemWoodenSword());

        }

        public static void storeBackgroundObject()
        {
            backgroundObjectType.Add("BackgroundOne", new BackgroundOne());
            backgroundObjectType.Add("BackgroundTwo", new BackgroundTwo());
            backgroundObjectType.Add("BackgroundThree", new BackgroundThree());
            backgroundObjectType.Add("BackgroundFour", new BackgroundFour());
            backgroundObjectType.Add("BackgroundFive", new BackgroundFive());
            backgroundObjectType.Add("BackgroundSix", new BackgroundSix());
            backgroundObjectType.Add("BackgroundSeven", new BackgroundSeven());
            backgroundObjectType.Add("BackgroundEight", new BackgroundEight());
            backgroundObjectType.Add("BackgroundNine", new BackgroundNine());
            backgroundObjectType.Add("BackgroundTen", new BackgroundTen());
            backgroundObjectType.Add("BackgroundEleven", new BackgroundEleven());
            backgroundObjectType.Add("BackgroundTwelve", new BackgroundTwelve());
            backgroundObjectType.Add("BackgroundThirteen", new BackgroundThirteen());
            backgroundObjectType.Add("BackgroundFourteen", new BackgroundFourteen());
            backgroundObjectType.Add("BackgroundFifteen", new BackgroundFifteen());
        }

        /*
        public static void storeBlockObject()
        {
            blockObjectType.Add("BlockDownShutDoor", new BlockDownShutDoor());
            blockObjectType.Add("BlockDownWall", new BlockDownWall());
            blockObjectType.Add("BlockGap", new BlockGap());
            blockObjectType.Add("BlockLadder", new BlockLadder());
            blockObjectType.Add("BlockLeftBombedOpening", new BlockLeftBombedOpening());
            blockObjectType.Add("BlockLeftLockedDoor", new BlockLeftLockedDoor());
            blockObjectType.Add("BlockLeftOpenDoor", new BlockLeftOpenDoor());
            blockObjectType.Add("BlockLeftShutDoor", new BlockLeftShutDoor());
            blockObjectType.Add("BlockLeftStatue", new BlockLeftStatue());
            blockObjectType.Add("BlockLeftWall", new BlockLeftWall());
            blockObjectType.Add("BlockRightBombedOpening", new BlockRightBombedOpening());
            blockObjectType.Add("BlockRightLockedDoor", new BlockRightLockedDoor());
            blockObjectType.Add("BlockRightOpenDoor", new BlockRightOpenDoor());
            blockObjectType.Add("BlockRightShutDoor", new BlockRightShutDoor());
            blockObjectType.Add("BlockRightStatue", new BlockRightStatue());
            blockObjectType.Add("BlockRightWall", new BlockRightWall());
            blockObjectType.Add("BlockSquare", new BlockSquare());
            blockObjectType.Add("BlockStairs", new BlockStairs());
            blockObjectType.Add("BlockUpBombedOpening", new BlockUpBombedOpening());
            blockObjectType.Add("BlockUpLockedDoor", new BlockUpLockedDoor());
            blockObjectType.Add("BlockUpOpenDoor", new BlockUpOpenDoor());
            blockObjectType.Add("BlockUpShutDoor", new BlockUpShutDoor());
            blockObjectType.Add("BlockUpWall", new BlockUpWall());
        }
        
        public static void storeCharObject()
        {
            charObjectType.Add("Aquamentus", new Aquamentus());
            charObjectType.Add("Dodongo", new Dodongo());
            charObjectType.Add("Gel", new Gel());
            charObjectType.Add("Keese", new Keese());
            charObjectType.Add("SpikeCross", new SpikeCross());
            charObjectType.Add("Stalfos", new Stalfos());
            charObjectType.Add("Zol", new Zol());
            charObjectType.Add("Old Man", new OldMan());


        }
        */

    }
}
