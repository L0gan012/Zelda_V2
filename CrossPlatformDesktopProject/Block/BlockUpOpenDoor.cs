namespace Sprint2
{
    public class BlockUpOpenDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorUp;

        public BlockUpOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
