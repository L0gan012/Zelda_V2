using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemBlueCandle : AbstractItem
    {
        public ItemBlueCandle()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBlueCandle();
            Position = Constant.ItemStartPosition;
        }

       
    }
}
