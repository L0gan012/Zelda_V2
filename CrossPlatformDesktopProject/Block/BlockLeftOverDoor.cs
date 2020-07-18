using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftOverDoor : AbstractBlock
    {
        public BlockLeftOverDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOverDoor();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.OverDoor;


        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}