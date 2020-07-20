using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockUpOverWall : AbstractBlock
    {
        public BlockUpOverWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpOverWall();
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