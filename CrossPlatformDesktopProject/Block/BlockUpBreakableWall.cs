using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockUpBreakableWall : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UpBreakableWall;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockUpBreakableWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
