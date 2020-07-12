namespace Sprint2
{
    public class BlockLeftTopWall : AbstractBlock
    {
        public BlockLeftTopWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftTopWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}