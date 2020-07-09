namespace Sprint2
{
    public class BlockTopLeftWall : AbstractBlock
    {
        public BlockTopLeftWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteTopLeftWall();
            Position = Constant.BlockStartPosition;
        }
    }
}