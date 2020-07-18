namespace Sprint2
{
    public class BlockRightOpenDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorRight;

        public BlockRightOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
