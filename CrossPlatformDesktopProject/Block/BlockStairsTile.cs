using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockStairsTile : AbstractGameObject, IDoorTrigger
    {
        public BlockStairsTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteStairsTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.StairsTrigger;
        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}