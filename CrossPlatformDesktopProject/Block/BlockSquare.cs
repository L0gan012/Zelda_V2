using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockSquare : AbstractBlock
    {
        public BlockSquare()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteSquare();
            Position = Constant.BlockStartPosition;
        }

        public override void Update()
        {
            if (Knockback && Vector2.Distance(Position, CollisionLocation) < Constant.BlockKnockback)
            {
                Position += Velocity;
            }
            else if (Knockback)
            {
                Knockback = false;
            }
            base.Update();
        }
    }
}
