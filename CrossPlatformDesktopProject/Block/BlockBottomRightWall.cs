using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockBottomRightWall : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Wall;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockBottomRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBottomRightWall();
            Position = Constant.BlockStartPosition;
        }
    }
}