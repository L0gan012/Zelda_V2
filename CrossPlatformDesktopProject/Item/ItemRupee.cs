using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemRupee : AbstractItem
    {
        public ItemRupee()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteRupee();
            Position = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
