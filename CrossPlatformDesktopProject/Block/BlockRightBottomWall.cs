namespace Sprint2
{
    public class BlockRightBottomWall : AbstractBlock
    {
        public BlockRightBottomWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightBottomWall();
            Position = Constant.BlockStartPosition;
        }
    }
}