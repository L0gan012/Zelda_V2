namespace Sprint2
{
    public class BlockFloorTile : AbstractBlock
    {
        public BlockFloorTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteFloorTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.FloorTile;
    }
}
