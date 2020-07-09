namespace Sprint2
{
    public class BlockTopRightWall : AbstractBlock
    {
        public BlockTopRightWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteTopRightWall();
            Position = Constant.BlockStartPosition;
        }
    }
}