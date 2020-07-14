namespace Sprint2
{
    public class BlockBottomLeftWall : AbstractBlock
    {
        public BlockBottomLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBottomLeftWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}
