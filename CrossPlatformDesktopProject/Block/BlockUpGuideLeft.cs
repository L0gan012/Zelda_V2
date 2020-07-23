namespace Sprint2
{
    public class BlockUpGuideLeft : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UpGuideLeft;

        public BlockUpGuideLeft()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite16x16Guide();
            Position = Constant.BlockStartPosition;
        }
    }
}