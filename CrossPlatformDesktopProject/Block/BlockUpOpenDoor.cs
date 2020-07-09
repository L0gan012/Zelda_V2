namespace Sprint2
{
    public class BlockUpOpenDoor : AbstractBlock
    {
        public BlockUpOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
