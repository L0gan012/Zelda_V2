namespace Sprint2
{
    public class BlockLadder : AbstractBlock
    {
        public BlockLadder()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLadder();
            Position = Constant.BlockStartPosition;
        }
    }
}
