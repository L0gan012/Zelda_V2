using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemRupee : AbstractItem
    {
        public ItemRupee()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteRupee();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
