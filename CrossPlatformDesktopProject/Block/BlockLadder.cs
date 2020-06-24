using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockLadder : AbstractBlock
    {
        public BlockLadder()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLadder();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
