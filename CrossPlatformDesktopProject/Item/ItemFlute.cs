using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemFlute : AbstractItem
    {
        public ItemFlute()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteFlute();
            Position = Constant.ItemStartPosition;
        }
    }
}
