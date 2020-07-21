namespace Sprint2
{
    public class BlockDownBombedDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorDown;

        public BlockDownBombedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownBombedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
