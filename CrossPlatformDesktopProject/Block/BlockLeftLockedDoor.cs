namespace Sprint2
{
    public class BlockLeftLockedDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorLeft;

        public BlockLeftLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftLockedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
