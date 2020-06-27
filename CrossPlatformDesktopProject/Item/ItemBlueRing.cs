using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemBlueRing : AbstractItem
    {
        public ItemBlueRing()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBlueRing();
            Position = Constant.ItemStartPosition;
        }
    }
}
