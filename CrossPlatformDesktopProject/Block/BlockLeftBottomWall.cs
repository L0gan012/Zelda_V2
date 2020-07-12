namespace Sprint2
{
    public class BlockLeftBottomWall : AbstractBlock
    {
        public BlockLeftBottomWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftBottomWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}