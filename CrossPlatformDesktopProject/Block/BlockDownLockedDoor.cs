namespace Sprint2
{
    public class BlockDownLockedDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorDown;

        public BlockDownLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownLockedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
