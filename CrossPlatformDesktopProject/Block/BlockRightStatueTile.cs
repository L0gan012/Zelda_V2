namespace Sprint2
{
    public class BlockRightStatueTile : AbstractBlock
    {
        public BlockRightStatueTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightStatueTile();
            Position = Constant.BlockStartPosition;
        }
    }
}