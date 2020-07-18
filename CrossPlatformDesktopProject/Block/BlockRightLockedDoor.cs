namespace Sprint2
{
    public class BlockRightLockedDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorRight;

        public BlockRightLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightLockedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
