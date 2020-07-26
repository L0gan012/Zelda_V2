using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightGuideDown : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.RightGuideDown;

        public BlockRightGuideDown()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite8x8Guide();
            Position = Constant.BlockStartPosition;
        }
    }
}