using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemFairy : AbstractItem
    {
        public ItemFairy()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteFairy();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
