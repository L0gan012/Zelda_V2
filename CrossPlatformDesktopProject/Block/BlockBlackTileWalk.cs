namespace Sprint2
{
    public class BlockBlackTileWalk : AbstractBlock
    {
        public BlockBlackTileWalk()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlackTile();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.FloorTile;
            


    }
}