using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockRightTopWall : AbstractBlock
    {
        public BlockRightTopWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightTopWall();
            Position = Constant.BlockStartPosition;
        }
    }
}