using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockLeftBottomWall : AbstractBlock
    {
        public BlockLeftBottomWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftBottomWall();
            Position = Constant.BlockStartPosition;
        }
    }
}