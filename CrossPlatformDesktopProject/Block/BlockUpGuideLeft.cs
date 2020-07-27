namespace Sprint2
{
    public class BlockUpGuideLeft : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UpGuideLeft;

        public BlockUpGuideLeft()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite8x8Guide();
            Position = Constant.BlockStartPosition;
        }
    }
}