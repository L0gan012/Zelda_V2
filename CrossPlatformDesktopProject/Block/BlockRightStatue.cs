using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockRightStatue : AbstractBlock
    {
        public BlockRightStatue()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightStatue();
            Position = Constant.BlockStartPosition;
        }
    }
}
