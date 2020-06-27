using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockStairs : AbstractBlock
    {
        public BlockStairs()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteStairs();
            Position = Constant.BlockStartPosition;
        }
    }
}
