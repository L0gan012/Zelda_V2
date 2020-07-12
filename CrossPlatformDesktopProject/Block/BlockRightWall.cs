namespace Sprint2
{
    public class BlockRightWall : AbstractBlock
    {
        public BlockRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}
