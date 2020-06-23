using Sprint2.Backgrounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Room
{
    public static class ObjectStorage
    {

        public static Dictionary<String, IItem> itemObjectType = new Dictionary<string, IItem>();
        public static Dictionary<String, INPC> charObjectType = new Dictionary<string, INPC>();
        public static Dictionary<String, IBackground> backgroundObjectType = new Dictionary<string, IBackground>();


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
            charObjectType.Add("Stalfos.", new Stalfos());
            charObjectType.Add("Zol", new Zol());

        }

        public static void storeBackgroundObject()
        {
            backgroundObjectType.Add("BackgroundOne", new BackgroundOne());


        }

    }
}
