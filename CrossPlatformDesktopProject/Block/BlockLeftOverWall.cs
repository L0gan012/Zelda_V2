using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftOverWall : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerLeft;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockLeftOverWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOverWall();
            Position = Constant.BlockStartPosition;
        }
    }
}