using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockUpOverBombed : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerUp;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockUpOverBombed()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpOverBombed();
            Position = Constant.BlockStartPosition;
        }
    }
}