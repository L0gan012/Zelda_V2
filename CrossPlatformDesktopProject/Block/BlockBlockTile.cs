using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockBlockTile : AbstractBlock
    {
        public BlockBlockTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlockTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Block;

    }
}