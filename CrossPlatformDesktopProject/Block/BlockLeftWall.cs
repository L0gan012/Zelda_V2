namespace Sprint2
{
    public class BlockLeftWall : AbstractBlock
    {
        public BlockLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}
