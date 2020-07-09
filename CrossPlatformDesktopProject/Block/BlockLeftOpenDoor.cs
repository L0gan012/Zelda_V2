namespace Sprint2
{
    public class BlockLeftOpenDoor : AbstractBlock
    {
        public BlockLeftOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
