using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemMap : AbstractItem
    {
        public ItemMap()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteMap();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
