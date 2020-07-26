using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftBottomWall : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Wall;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockLeftBottomWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftBottomWall();
            Position = Constant.BlockStartPosition;
        }
    }
}