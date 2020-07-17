namespace Sprint2
{
    public class BlockLeftShutDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorLeft;

        public BlockLeftShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
