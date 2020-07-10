namespace Sprint2
{
    public class BlockRightTopWall : AbstractBlock
    {
        public BlockRightTopWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightTopWall();
            Position = Constant.BlockStartPosition;
        }
    }
}