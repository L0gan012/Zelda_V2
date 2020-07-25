namespace Sprint2
{
    public class BlockFloorTile : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.FloorTile;

        public BlockFloorTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteFloorTile();
            Position = Constant.BlockStartPosition;
        }
    }
}
