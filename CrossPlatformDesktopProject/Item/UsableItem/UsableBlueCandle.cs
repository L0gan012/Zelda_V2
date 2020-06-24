using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBlueCandle : AbstractUsableMoving
    {
        private Rectangle range;

        public UsableBlueCandle(ILink link)
        {
            Link = link;
            Color = Color.White;
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileCandle();
            int distance = Constant.FlameDistance;
            range = new Rectangle((int)link.Center.X - distance, (int)link.Center.Y - distance, + 2*distance, 2*distance);
        }

        public override void Update()
        {
            Position = new Vector2(Position.X + DeltaX * Constant.FlameSpeed, Position.Y + DeltaY * Constant.FlameSpeed);

            if (!range.Contains(Center))
            {
                Link.SecondaryItem = null;
            }

            base.Update();
        }
    }
}
