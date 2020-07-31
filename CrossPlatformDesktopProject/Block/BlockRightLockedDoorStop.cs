namespace Sprint2
{
    public class BlockRightLockedDoorStop : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.RightLockStop;

        public BlockRightLockedDoorStop()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite16x16Guide();
            Position = Constant.BlockStartPosition;
        }
    }
}