using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightOverDoor : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerRight;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockRightOverDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightOverDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}