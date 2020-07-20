using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockLeftOverWall : AbstractBlock
    {
        public BlockLeftOverWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOverWall();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerLeft;


        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}