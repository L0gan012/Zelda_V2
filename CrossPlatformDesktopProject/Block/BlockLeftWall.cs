using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockLeftWall : AbstractBlock
    {
        public BlockLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
