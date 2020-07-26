using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockDoorTriggerTreasureExit : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerExitTreasureRoom;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockDoorTriggerTreasureExit()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBlackTile();
            Position = Constant.BlockStartPosition;
        }
    }
}