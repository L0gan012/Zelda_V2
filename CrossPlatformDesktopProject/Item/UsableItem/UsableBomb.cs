namespace Sprint2
{
    public class UsableBomb : AbstractUsable
    {
        private int timer;
        private IPlayer link;

        public UsableBomb(IPlayer user)
        {
            link = user;
            User = user;
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteBomb();
            timer = Constant.BombTimer;
        }
        
        public override void Update()
        {
            base.Update();
            timer--;

            if(timer == 0)
            {
                IsDestructable = true;
                // set damage amount only when exploding, otherwise set it to 0
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
