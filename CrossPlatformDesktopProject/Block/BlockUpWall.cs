using System;
using Microsoft.Xna.Framework;


namespace Sprint2.Block
{
    class BlockUpWall : AbstractBlock
    {
        public BlockUpWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpWall();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
