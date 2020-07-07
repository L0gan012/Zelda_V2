using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockBottomLeftWall : AbstractBlock
    {
        public BlockBottomLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBottomLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
