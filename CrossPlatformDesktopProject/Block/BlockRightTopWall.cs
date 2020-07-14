﻿namespace Sprint2
{
    public class BlockRightTopWall : AbstractBlock
    {
        public BlockRightTopWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightTopWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}