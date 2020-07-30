using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemFairy : AbstractItem
    {
        private int movementTimer = 0;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemEquipment;

        public ItemFairy()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteFairy();
            Position = Constant.ItemStartPosition;
        }

        public override void Update()
        {
            MoveFairy();
            base.Update();
        }

        public override void PickUp(IPlayer user)
        {
            base.PickUp(user);
            user.HP += 5;
        }

        private void MoveFairy()
        {
            if (movementTimer == ItemConstants.FairyMovementTimer)
            {
                Velocity = Vector2.UnitX * Constant.RNG.Next(-1, 2) * ItemConstants.FairySpeed + Vector2.UnitY * Constant.RNG.Next(-1, 2) * ItemConstants.FairySpeed;
                movementTimer = 0;
            }
            Position += Velocity;
            movementTimer++;
        }
    }
}
