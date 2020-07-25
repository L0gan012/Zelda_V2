﻿namespace Sprint2
{
    public class BlockLeftStatueTile : AbstractBlock
    {
        public BlockLeftStatueTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftStatueTile();
            Position = Constant.BlockStartPosition;
        }
    }
}