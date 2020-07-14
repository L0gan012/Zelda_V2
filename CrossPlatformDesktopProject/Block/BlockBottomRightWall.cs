namespace Sprint2
{
    public class BlockBottomRightWall : AbstractBlock
    {
        public BlockBottomRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBottomRightWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}