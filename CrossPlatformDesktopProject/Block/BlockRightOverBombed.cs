using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightOverBombed : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerRight;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockRightOverBombed()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightOverBombed();
            Position = Constant.BlockStartPosition;
        }
    }
}