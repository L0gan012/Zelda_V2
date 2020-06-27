using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemRaft : AbstractItem
    {
        public ItemRaft()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteRaft();
            Position = Constant.ItemStartPosition;
        }
    }
}
