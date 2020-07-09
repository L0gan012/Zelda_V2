namespace Sprint2
{
    public class BlockGap : AbstractBlock
    {
        public BlockGap()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteGap();
            Position = Constant.BlockStartPosition;
        }

    }
}
