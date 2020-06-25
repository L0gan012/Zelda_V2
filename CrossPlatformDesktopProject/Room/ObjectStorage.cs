using Sprint2.Block;
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
            blockObjectType.Add("BlockUpLockedDoor", new BlockRightStatue());
            blockObjectType.Add("BlockUpOpenDoor", new BlockRightWall());
            blockObjectType.Add("BlockUpShutDoor", new BlockSquare());
            blockObjectType.Add("BlockUpWall", new BlockStairs());
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
            itemObjectType.Add("ItemHeart", new ItemHeartContainer());
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
            //storeObjectType.Add("ItemTriforcePiece", new ItemTriforcePiece());
            itemObjectType.Add("ItemWhiteSword", new ItemWhiteSword());
            itemObjectType.Add("ItemWoodenArrow", new ItemWoodenArrow());
            //storeObjectType.Add("ItemWoodenBoomerang", new ItemWoodenBoomerang());
            //storeObjectType.Add("ItemWoodenSword", new ItemWoodenSword());

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

    }
}
