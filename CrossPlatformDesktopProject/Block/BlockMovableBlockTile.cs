namespace Sprint2
{
    public class BlockMovableBlockTile : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.MovableBlock;

        public BlockMovableBlockTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlockTile();
            Position = Constant.BlockStartPosition;
            IsMovable = true;
        }
    }
}