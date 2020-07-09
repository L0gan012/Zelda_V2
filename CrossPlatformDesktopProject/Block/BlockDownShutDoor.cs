namespace Sprint2
{
    public class BlockDownShutDoor : AbstractBlock
    {
        public BlockDownShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
