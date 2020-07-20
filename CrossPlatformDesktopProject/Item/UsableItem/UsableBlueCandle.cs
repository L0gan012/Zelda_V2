using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBlueCandle : AbstractUsableMoving
    {
        private Rectangle range;
        private int distance;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UsableItemVsEnemy;

        public UsableBlueCandle(IGameObject user)
        {
            User = user;
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileCandle();
            InventoryPosition = Constant.CandleInventoryPosition;

            distance = Constant.FlameDistance;
            range = new Rectangle((int)user.Center.X - distance, (int)user.Center.Y - distance, + 2*distance, 2*distance);
        }

        public override void Update()
        {
            range = new Rectangle((int)User.Center.X - distance, (int)User.Center.Y - distance, +2 * distance, 2 * distance);
            Position += Velocity * Constant.FlameSpeed;

            if (!range.Contains(Center))
            {
                IsDestructable = true;
            }

            base.Update();
        }
    }
}
