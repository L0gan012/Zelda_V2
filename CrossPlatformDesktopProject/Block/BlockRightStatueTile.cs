using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightStatueTile : AbstractBlock
    {
        public BlockRightStatueTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightStatueTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Block;

    }
}