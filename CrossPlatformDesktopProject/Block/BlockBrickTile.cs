using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockBrickTile : AbstractBlock
    {
        public BlockBrickTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteBrickTile();
            Position = Constant.BlockStartPosition;
        }

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Block;


        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}