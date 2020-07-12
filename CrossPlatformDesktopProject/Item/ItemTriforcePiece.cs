using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemTriforcePiece : AbstractItem
    {
        public ItemTriforcePiece()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteItemTriforcePiece();
            Position = Constant.ItemStartPosition;

        }

        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.ItemTriforcePiece;
            set => _ = Enumerations.GameObjectType.ItemTriforcePiece;
        }

    }
}
