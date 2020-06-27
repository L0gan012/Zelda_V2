using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemPowerBracelet : AbstractItem
    {
        public ItemPowerBracelet()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpritePowerBracelet();
            Position = Constant.ItemStartPosition;
        }
    }
}
