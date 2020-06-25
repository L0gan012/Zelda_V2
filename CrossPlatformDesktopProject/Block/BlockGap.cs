using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockGap : AbstractBlock
    {
        public BlockGap()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteGap();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }

    }
}
