namespace Sprint2
{
    public class BlockRightShutDoor : AbstractBlock
    {
        public BlockRightShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
