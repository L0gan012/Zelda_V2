namespace Sprint2
{
    public class BlockLeftStatue : AbstractBlock
    {
        public BlockLeftStatue()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftStatue();
            Position = Constant.BlockStartPosition;
        }
    }
}
