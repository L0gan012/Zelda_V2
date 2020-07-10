﻿namespace Sprint2
{
    public class BlockRightWall : AbstractBlock
    {
        public BlockRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
