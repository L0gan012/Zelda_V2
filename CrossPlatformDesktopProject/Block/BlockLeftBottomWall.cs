namespace Sprint2
{
    public class BlockLeftBottomWall : AbstractBlock
    {
        public BlockLeftBottomWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftBottomWall();
            Position = Constant.BlockStartPosition;
        }
    }
}