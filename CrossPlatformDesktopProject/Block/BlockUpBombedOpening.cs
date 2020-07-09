namespace Sprint2
{
    public class BlockUpBombedOpening : AbstractBlock
    {
        public BlockUpBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpBombedOpening();
            Position = Constant.BlockStartPosition;
        }
    }
}
