﻿using Microsoft.Xna.Framework;

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
            InventoryPosition = new Vector2(HUDConstants.CandleInventoryPosition.X, HUDConstants.CandleInventoryPosition.Y);
            DamageAmount = ItemConstants.FlameDamageAmount;
            distance = ItemConstants.FlameDistance;
            range = new Rectangle((int)user.Center.X - distance, (int)user.Center.Y - distance, + 2*distance, 2*distance);
        }

        public override void Update()
        {
            range = new Rectangle((int)User.Center.X - distance, (int)User.Center.Y - distance, +2 * distance, 2 * distance);
            Position += Velocity * ItemConstants.FlameSpeed;

            if (!range.Contains(Center))
            {
                IsDestructable = true;
            }

            base.Update();
        }

        public override void UseLeft()
        {
            SoundManager.Instance.PlayCandleUse();
            base.UseLeft();
        }

        public override void UseRight()
        {
            SoundManager.Instance.PlayCandleUse();
            base.UseRight();
        }

        public override void UseUp()
        {
            SoundManager.Instance.PlayCandleUse();
            base.UseUp();
        }

        public override void UseDown()
        {
            SoundManager.Instance.PlayCandleUse();
            base.UseDown();
        }
    }
}
