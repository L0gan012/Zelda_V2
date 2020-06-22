using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemFiveRupee : AbstractItem
    {
        public ItemFiveRupee()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteRupee();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
