namespace Sprint2
{
    public class BlockTopLeftWall : AbstractBlock
    {
        public BlockTopLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteTopLeftWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}