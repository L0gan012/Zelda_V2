using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockDownOverBombed : AbstractBlock
    {
        public BlockDownOverBombed()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownOverBombed();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerDown;


        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}