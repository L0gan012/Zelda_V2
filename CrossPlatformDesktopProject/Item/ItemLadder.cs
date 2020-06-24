using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemLadder : AbstractItem
    {
        public ItemLadder()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteLadder();
            Position = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
