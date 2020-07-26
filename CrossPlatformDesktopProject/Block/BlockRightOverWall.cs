using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightOverWall : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerRight;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockRightOverWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightOverWall();
            Position = Constant.BlockStartPosition;
        }
    }
}