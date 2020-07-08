using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockTopRightWall : AbstractBlock
    {
        public BlockTopRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteTopRightWall();
            Position = Constant.BlockStartPosition;
        }
    }
}