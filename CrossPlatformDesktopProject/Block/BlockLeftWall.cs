using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftWall : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Wall;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
