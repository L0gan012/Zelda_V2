using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftSealedDoorStop : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.LeftSealStop;

        public BlockLeftSealedDoorStop()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSprite16x16Guide();
            Position = Constant.BlockStartPosition;
        }
        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }

}