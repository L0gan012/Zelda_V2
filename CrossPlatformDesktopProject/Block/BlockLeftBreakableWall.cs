using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftBreakableWall : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.LeftBreakableWall;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockLeftBreakableWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
