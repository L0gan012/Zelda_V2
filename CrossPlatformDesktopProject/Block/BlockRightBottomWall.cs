﻿namespace Sprint2
{
    public class BlockRightBottomWall : AbstractBlock
    {
        public BlockRightBottomWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightBottomWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Wall;
    }
}