using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Inventory : IInventory
    {
        public int RupeeCount { get; set; }
        public int KeyCount { get; set; }
        public int BombCount { get; set; }

        public bool HasMap { get; set; }
        public bool HasCompass { get; set; }
        public bool HasArrows { get; set; }

        public Dictionary<IItem, IUsableItem> ItemCache { get; }

        public Inventory()
        {
            RupeeCount = 0;
            KeyCount = 0;
            BombCount = 0;

            HasMap = false;
            HasCompass = false;
            HasArrows = false;

            ItemCache = new Dictionary<IItem, IUsableItem>();
        }
    }
}
