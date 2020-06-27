using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemTriforcePiece : AbstractItem
    {
        public ItemTriforcePiece()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteTriforcePiece();
            Position = Constant.ItemStartPosition;
            Color = Color.White;
        }

       
    }
}
