using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftOverBombed : AbstractBlock
    {
        public BlockLeftOverBombed()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOverBombed();
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