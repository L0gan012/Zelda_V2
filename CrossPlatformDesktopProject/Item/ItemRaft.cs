using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemRaft : AbstractItem
    {
        public ItemRaft()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteRaft();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
