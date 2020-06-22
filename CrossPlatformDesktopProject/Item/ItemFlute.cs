using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemFlute : AbstractItem
    {
        public ItemFlute()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteFlute();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
