namespace Sprint2
{
    public class BlockBrick : AbstractBlock
    {
        public BlockBrick()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBrick();
            Position = Constant.BlockStartPosition;
        }
    }
}
