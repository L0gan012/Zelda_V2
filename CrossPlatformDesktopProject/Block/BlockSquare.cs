namespace Sprint2
{
    public class BlockSquare : AbstractBlock
    {
        public BlockSquare()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteSquare();
            Position = Constant.BlockStartPosition;
        }
    }
}
