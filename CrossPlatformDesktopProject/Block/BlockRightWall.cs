namespace Sprint2
{
    public class BlockRightWall : AbstractBlock
    {
        public BlockRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Wall;
    }
}
