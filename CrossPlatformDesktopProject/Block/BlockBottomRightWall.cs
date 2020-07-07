using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockBottomRightWall : AbstractBlock
    {
        public BlockBottomRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBottomRightWall();
            Position = Constant.BlockStartPosition;
        }
    }
}