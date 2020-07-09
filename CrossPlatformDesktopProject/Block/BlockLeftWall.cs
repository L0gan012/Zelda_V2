namespace Sprint2
{
    public class BlockLeftWall : AbstractBlock
    {
        public BlockLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
