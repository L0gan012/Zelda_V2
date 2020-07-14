namespace Sprint2
{
    public class BlockTopRightWall : AbstractBlock
    {
        public BlockTopRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteTopRightWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}