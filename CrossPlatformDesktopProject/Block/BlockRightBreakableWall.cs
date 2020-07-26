using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightBreakableWall : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.RightBreakableWall;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockRightBreakableWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
