using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemRedPotion : AbstractItem
    {
        public ItemRedPotion()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteRedPotion();
            Position = Constant.ItemStartPosition;
        }
    }
}
