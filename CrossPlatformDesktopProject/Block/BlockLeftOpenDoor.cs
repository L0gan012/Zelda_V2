namespace Sprint2
{
    public class BlockLeftOpenDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorLeft;

        public BlockLeftOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
