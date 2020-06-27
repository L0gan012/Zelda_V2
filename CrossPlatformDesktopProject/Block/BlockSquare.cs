using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockSquare : AbstractBlock
    {
        public override bool IsMovable { get; set; }
        public override Vector2 Velocity { get; set; }

        public BlockSquare()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteSquare();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
