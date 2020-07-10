namespace Sprint2
{
    public class BlockLeftTopWall : AbstractBlock
    {
        public BlockLeftTopWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftTopWall();
            Position = Constant.BlockStartPosition;
        }
    }
}