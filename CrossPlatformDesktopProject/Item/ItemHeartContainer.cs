using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemHeartContainer : AbstractItem
    {
        public ItemHeartContainer()
        {
           Sprite = ItemsSpriteFactory.Instance.CreateSpriteHeartContainer();
           Position = Constant.ItemStartPosition;
           Color = Color.White;
        }
    }
}
