using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockUpGuideLeft : AbstractBlock
    {
        public BlockUpGuideLeft()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite16x16Guide();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UpGuideLeft;

    }
}