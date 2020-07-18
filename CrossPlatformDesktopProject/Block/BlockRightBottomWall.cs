using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightBottomWall : AbstractBlock
    {
        public BlockRightBottomWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightBottomWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Wall;
        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}