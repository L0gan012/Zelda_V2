namespace Sprint2
{
    public class BlockBottomRightWall : AbstractBlock
    {
        public BlockBottomRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBottomRightWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Wall;
    }
}