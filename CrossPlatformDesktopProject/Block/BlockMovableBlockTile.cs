using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockMovableBlockTile : AbstractBlock
    {
        public BlockMovableBlockTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlockTile();
            Position = Constant.BlockStartPosition;
            IsMovable = true;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.MovableBlock;

    }
}