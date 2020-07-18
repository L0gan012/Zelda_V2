namespace Sprint2
{
    public class BlockRightShutDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorRight;

        public BlockRightShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
