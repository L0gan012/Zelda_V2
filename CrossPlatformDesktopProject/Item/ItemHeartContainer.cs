using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemHeartContainer : AbstractItem
    {
        public ItemHeartContainer()
        {
           Sprite = ItemsSpriteFactory.Instance.CreateSpriteHeartContainer();
           Location = Constant.ItemStartPosition;
           Color = Color.White;
        }
    }
}
