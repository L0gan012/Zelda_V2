namespace Sprint2
{
    public class BlockDownWall : AbstractBlock
    {
        public BlockDownWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownWall();
            Position = Constant.BlockStartPosition;
        }
    }
}
