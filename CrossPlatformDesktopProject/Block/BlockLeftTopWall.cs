using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockLeftTopWall : AbstractBlock
    {
        public BlockLeftTopWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftTopWall();
            Position = Constant.BlockStartPosition;
        }
    }
}