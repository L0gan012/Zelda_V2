namespace Sprint2
{
    public class BlockLeftLockedDoor : AbstractBlock
    {
        public BlockLeftLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOpenDoor();
            Position = Constant.BlockStartPosition;
        }

    }
}
