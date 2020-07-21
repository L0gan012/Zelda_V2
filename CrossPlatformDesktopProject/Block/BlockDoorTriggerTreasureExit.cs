using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockDoorTriggerTreasureExit : AbstractGameObject, IDoorTrigger
    {
        public BlockDoorTriggerTreasureExit()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlackTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerExitTreasureRoom;


        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}