namespace Sprint2
{
    public class BlockRightBombedOpening : AbstractBlock
    {
        public BlockRightBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightBombedOpening();
            Position = Constant.BlockStartPosition;
        }

    }
}
