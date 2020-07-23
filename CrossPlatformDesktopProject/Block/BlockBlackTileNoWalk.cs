using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockBlackTileNoWalk : AbstractBlock
    {
        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockBlackTileNoWalk()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlackTile();
            Position = Constant.BlockStartPosition;
        }
    }
}