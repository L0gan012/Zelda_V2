namespace Sprint2
{
    public class BlockRightStatue : AbstractBlock
    {
        public BlockRightStatue()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightStatue();
            Position = Constant.BlockStartPosition;
        }
    }
}
