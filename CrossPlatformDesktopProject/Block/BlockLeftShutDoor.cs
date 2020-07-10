namespace Sprint2
{
    public class BlockLeftShutDoor : AbstractBlock
    {
        public BlockLeftShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
