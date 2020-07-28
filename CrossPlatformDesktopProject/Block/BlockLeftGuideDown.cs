namespace Sprint2
{
    public class BlockLeftGuideDown : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.LeftGuideDown;

        public BlockLeftGuideDown()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite8x8Guide();
            Position = Constant.BlockStartPosition;
        }
    }
}