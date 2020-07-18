using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftStatueTile : AbstractBlock
    {
        public BlockLeftStatueTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftStatueTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Block;

    }
}