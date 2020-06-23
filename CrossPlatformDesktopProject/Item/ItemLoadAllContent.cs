namespace Sprint2
{
    public class ItemLoadAllContent
    {
        GameObjects objects;
        
        public ItemLoadAllContent(Game1 game)
        {
            objects = new GameObjects(game);
        }

        public void LoadContent()
        {
            objects.ListOfItems.Add(new ItemBlueCandle());
            objects.ListOfItems.Add(new ItemBluePotion());
            objects.ListOfItems.Add(new ItemBlueRing());
            objects.ListOfItems.Add(new ItemBomb());
            objects.ListOfItems.Add(new ItemBow());
            objects.ListOfItems.Add(new ItemClock());
            objects.ListOfItems.Add(new ItemCompass());
            objects.ListOfItems.Add(new ItemFairy());
            objects.ListOfItems.Add(new ItemFiveRupee());
            objects.ListOfItems.Add(new ItemFlute());
            objects.ListOfItems.Add(new ItemHeartContainer());
            objects.ListOfItems.Add(new ItemKey());
            objects.ListOfItems.Add(new ItemLadder());
            objects.ListOfItems.Add(new ItemMagicBoomerang());
            objects.ListOfItems.Add(new ItemMagicRod());
            objects.ListOfItems.Add(new ItemMagicShield());
            objects.ListOfItems.Add(new ItemMap());
            objects.ListOfItems.Add(new ItemPotionNote());
            objects.ListOfItems.Add(new ItemPowerBracelet());
            objects.ListOfItems.Add(new ItemRaft());
            objects.ListOfItems.Add(new ItemRedPotion());
            objects.ListOfItems.Add(new ItemRupee());
            objects.ListOfItems.Add(new ItemSilverArrow());
            objects.ListOfItems.Add(new ItemWhiteSword());
            objects.ListOfItems.Add(new ItemWoodenArrow());
        }
    }
}
