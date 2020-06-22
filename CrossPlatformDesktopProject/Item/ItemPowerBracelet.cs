using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemPowerBracelet : AbstractItem
    {
        public ItemPowerBracelet()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpritePowerBracelet();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
