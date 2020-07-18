using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockWaterTile : AbstractBlock
    {
        public BlockWaterTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteWaterTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Block;

    }
}