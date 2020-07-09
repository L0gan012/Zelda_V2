namespace Sprint2
{
    public class BlockUpLockedDoor : AbstractBlock
    {
        public BlockUpLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpLockedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
