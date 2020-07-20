using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockDownGuideRight : AbstractBlock
    {
        public BlockDownGuideRight()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite16x16Guide();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DownGuideRight;

    }
}