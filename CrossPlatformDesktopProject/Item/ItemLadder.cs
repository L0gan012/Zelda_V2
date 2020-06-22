using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemLadder : AbstractItem
    {
        public ItemLadder()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteLadder();
            Location = Constant.ItemStartPosition;
            Color = Color.White;
        }
    }
}
