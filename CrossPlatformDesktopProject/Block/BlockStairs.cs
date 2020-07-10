namespace Sprint2
{
    public class BlockStairs : AbstractBlock
    {
        public BlockStairs()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteStairs();
            Position = Constant.BlockStartPosition;
        }
    }
}
