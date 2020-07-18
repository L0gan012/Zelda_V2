namespace Sprint2
{
    public class BlockDownShutDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorDown;

        public BlockDownShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
