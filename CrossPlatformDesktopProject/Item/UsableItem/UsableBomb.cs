namespace Sprint2
{
    public class UsableBomb : AbstractUsable
    {
        private int timer;
        private IPlayer link;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemInstant;

        public UsableBomb(IPlayer user)
        {
            User = user;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            InventoryPosition = Constant.BombInventoryPosition;
            DamageAmount = 0;

            link = user;
            timer = Constant.BombTimer;
        }
        
        public override void Update()
        {
            base.Update();
            timer--;

            if(timer == Constant.BombExplosionTime)
            {
                DamageAmount = Constant.BombExplosionDamageAmount;
                GameObjectType = Enumerations.GameObjectType.UsableItemVsAll;
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileBombExplosion();
            }
            if(timer <= 0)
            {
                IsDestructable = true;
                timer = Constant.BombTimer;
                // set damage amount only when exploding, otherwise set it to 0
                DamageAmount = 0;
                GameObjectType = Enumerations.GameObjectType.ItemInstant;
                Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            }
        }

        private bool InventoryAgrees()
        {
            bool canUseBomb = link.Inventory.BombCount > 0;
            if (canUseBomb)
            {
                link.Inventory.BombCount--;
            }

            return canUseBomb;
        }

        public override void UseLeft()
        {
            if (InventoryAgrees())
            {
                base.UseLeft();
            }
            
        }

        public override void UseRight()
        {
            if (InventoryAgrees())
            {
                base.UseRight();
            }
        }

        public override void UseUp()
        {
            if (InventoryAgrees())
            {
                base.UseUp();
            }
        }

        public override void UseDown()
        {
            if (InventoryAgrees())
            {
                base.UseDown();
            }
        }
    }
}
