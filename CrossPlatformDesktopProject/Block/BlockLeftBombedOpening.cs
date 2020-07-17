namespace Sprint2
{
    public class BlockLeftBombedOpening : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorLeft;

        public BlockLeftBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftBombedOpening();
            Position = Constant.BlockStartPosition;
        }
    }
}
