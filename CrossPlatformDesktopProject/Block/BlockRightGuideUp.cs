using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightGuideUp : AbstractBlock
    {
        public BlockRightGuideUp()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite16x16Guide();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.RightGuideUp;

    }
}