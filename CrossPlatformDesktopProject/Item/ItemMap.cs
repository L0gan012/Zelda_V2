using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemMap : AbstractItem
    {
        public ItemMap()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteMap();
            Position = Constant.ItemStartPosition;
        }
    }
}
