namespace Sprint2
{
    public class BlockUpLockedDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorUp;

        public BlockUpLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpLockedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
