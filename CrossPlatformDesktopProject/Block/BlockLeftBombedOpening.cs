namespace Sprint2
{
    public class BlockLeftBombedOpening : AbstractBlock
    {
        public BlockLeftBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftBombedOpening();
            Position = Constant.BlockStartPosition;
        }
    }
}
