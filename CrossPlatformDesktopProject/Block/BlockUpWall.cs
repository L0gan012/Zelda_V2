namespace Sprint2
{
    public class BlockUpWall : AbstractBlock
    {
        public BlockUpWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}
