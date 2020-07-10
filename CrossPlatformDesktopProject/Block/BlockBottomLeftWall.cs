namespace Sprint2
{
    public class BlockBottomLeftWall : AbstractBlock
    {
        public BlockBottomLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBottomLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
