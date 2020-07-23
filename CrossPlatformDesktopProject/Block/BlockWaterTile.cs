namespace Sprint2
{
    public class BlockWaterTile : AbstractBlock
    {
        public BlockWaterTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteWaterTile();
            Position = Constant.BlockStartPosition;
        }
    }
}