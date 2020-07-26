namespace Sprint2
{
    public class BlockDownGuideRight : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DownGuideRight;

        public BlockDownGuideRight()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite8x8Guide();
            Position = Constant.BlockStartPosition;
        }
    }
}