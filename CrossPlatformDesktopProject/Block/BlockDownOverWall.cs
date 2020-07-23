using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockDownOverWall : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerDown;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockDownOverWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownOverWall();
            Position = Constant.BlockStartPosition;
        }
    }
}