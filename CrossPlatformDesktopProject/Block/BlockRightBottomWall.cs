using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockRightBottomWall : AbstractBlock
    {
        public BlockRightBottomWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightBottomWall();
            Position = Constant.BlockStartPosition;
        }
    }
}