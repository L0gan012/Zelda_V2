namespace Sprint2
{
    public class BlockRightLockedDoor : AbstractBlock
    {
        public BlockRightLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightLockedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
