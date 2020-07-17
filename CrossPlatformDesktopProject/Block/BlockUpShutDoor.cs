namespace Sprint2
{
    public class BlockUpShutDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorUp;

        public BlockUpShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
