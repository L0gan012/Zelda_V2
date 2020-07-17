namespace Sprint2
{
    public class BlockRightBombedOpening : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorRight;

        public BlockRightBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightBombedOpening();
            Position = Constant.BlockStartPosition;
        }

    }
}
