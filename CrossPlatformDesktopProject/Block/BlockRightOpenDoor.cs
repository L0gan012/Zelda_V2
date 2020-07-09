namespace Sprint2
{
    public class BlockRightOpenDoor : AbstractBlock
    {
        public BlockRightOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
