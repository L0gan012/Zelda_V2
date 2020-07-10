using System.Collections.Generic;

namespace Sprint2
{
    public interface IInventory
    {
        int RupeeCount { get; set; }
        int KeyCount { get; set; }
        int BombCount { get; set; }

        bool HasMap { get; set; }
        bool HasCompass { get; set; }
        bool HasArrows { get; set; }

        Dictionary<IItem, IUsableItem> ItemCache { get; }
    }
}
