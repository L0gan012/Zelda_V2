namespace Sprint2
{
    public class BlockDownWall : AbstractBlock
    {
        public BlockDownWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownWall();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Wall;
            set => _ = Enumerations.GameObjectType.Wall;
        }
    }
}
