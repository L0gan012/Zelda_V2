using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockTopLeftWall : AbstractBlock
    {
        public BlockTopLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteTopLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}