namespace Sprint2
{
    public class BlockBlockTile : AbstractBlock
    {
        public BlockBlockTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlockTile();
            Position = Constant.BlockStartPosition;
        }
    }
}