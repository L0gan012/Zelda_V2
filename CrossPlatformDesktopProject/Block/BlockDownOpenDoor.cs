namespace Sprint2
{
    public class BlockDownOpenDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorDown;

        public BlockDownOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
