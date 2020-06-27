using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockRightWall : AbstractBlock
    {
        public BlockRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
