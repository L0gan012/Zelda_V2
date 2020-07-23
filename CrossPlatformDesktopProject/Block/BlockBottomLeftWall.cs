using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockBottomLeftWall : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Wall;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockBottomLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBottomLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
