using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBlueCandle : AbstractUsableMoving
    {
        private Rectangle range;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.Fire;

        public UsableBlueCandle(IGameObject user)
        {
            User = user;
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileCandle();

            int distance = Constant.FlameDistance;
            range = new Rectangle((int)user.Center.X - distance, (int)user.Center.Y - distance, + 2*distance, 2*distance);
        }

        public override void Update()
        {
            Position += Velocity * Constant.FlameSpeed;

            if (!range.Contains(Center))
            {
                IsDestructable = true;
            }

            base.Update();
        }
    }
}
