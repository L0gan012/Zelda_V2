namespace Sprint2
{
    public class BlockDownGuideLeft : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DownGuideLeft;

        public BlockDownGuideLeft()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite8x8Guide();
            Position = Constant.BlockStartPosition;
        }
    }
}