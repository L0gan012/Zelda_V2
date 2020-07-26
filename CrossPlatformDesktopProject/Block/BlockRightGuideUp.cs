namespace Sprint2
{
    public class BlockRightGuideUp : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.RightGuideUp;

        public BlockRightGuideUp()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite8x8Guide();
            Position = Constant.BlockStartPosition;
        }
    }
}