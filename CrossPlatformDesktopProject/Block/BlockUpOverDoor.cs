using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockUpOverDoor : AbstractBlock
    {
        public BlockUpOverDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpOverDoor();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerUp;


        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}