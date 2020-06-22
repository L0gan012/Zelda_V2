 using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemClock : AbstractItem
    {
        public ItemClock()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteClock();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
