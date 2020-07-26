using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockDownOverBombed : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerDown;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockDownOverBombed()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownOverBombed();
            Position = Constant.BlockStartPosition;
        }
    }
}