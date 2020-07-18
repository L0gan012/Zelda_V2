namespace Sprint2
{
    public class BlockUpBombedOpening : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorUp;

        public BlockUpBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpBombedOpening();
            Position = Constant.BlockStartPosition;
        }
    }
}
