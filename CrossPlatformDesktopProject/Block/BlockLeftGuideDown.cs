using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftGuideDown : AbstractBlock
    {
        public BlockLeftGuideDown()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite16x16Guide();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.LeftGuideDown;

    }
}