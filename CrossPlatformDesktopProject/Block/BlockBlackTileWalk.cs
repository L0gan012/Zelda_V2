namespace Sprint2
{
    public class BlockBlackTileWalk : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.FloorTile;

        public BlockBlackTileWalk()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlackTile();
            Position = Constant.BlockStartPosition;
        }
    }
}