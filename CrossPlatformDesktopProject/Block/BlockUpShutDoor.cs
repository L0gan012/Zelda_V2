namespace Sprint2
{
    public class BlockUpShutDoor : AbstractBlock
    {
        public BlockUpShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
