using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockTopRightWall : AbstractBlock
    {
        public BlockTopRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteTopRightWall();
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