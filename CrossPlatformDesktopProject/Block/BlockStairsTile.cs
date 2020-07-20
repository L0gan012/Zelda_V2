using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockStairsTile : AbstractBlock
    {
        public BlockStairsTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteStairsTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.StairsTriggerTile;

    }
}