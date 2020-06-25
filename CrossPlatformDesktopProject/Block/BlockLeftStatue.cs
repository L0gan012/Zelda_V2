using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockLeftStatue : AbstractBlock
    {
        public BlockLeftStatue()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftStatue();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
