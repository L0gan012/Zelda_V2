namespace Sprint2
{
    public class BlockUpWall : AbstractBlock
    {
        public BlockUpWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
