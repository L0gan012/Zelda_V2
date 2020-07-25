using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBomb : AbstractUsable
    {
        private int timer;
        private IPlayer link;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.ItemUsableBomb;

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
                GameObjectType = Enumerations.GameObjectType.UsableItemBomb;
                Position =  new Vector2(Position.X - 16 * Constant.DisplayScaleX, Position.Y - 16 * Constant.DisplayScaleY);
                Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileBombExplosion();
                SoundManager.Instance.PlayBombExplode();
            }
            if(timer <= 0)
            {
                IsDestructable = true;
                timer = Constant.BombTimer;
                // set damage amount only when exploding, otherwise set it to 0
                DamageAmount = 0;
                GameObjectType = Enumerations.GameObjectType.ItemUsableBomb;
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
                SoundManager.Instance.PlayBombPlace();
                base.UseLeft();
            }
            
        }

        public override void UseRight()
        {
            if (InventoryAgrees())
            {
                SoundManager.Instance.PlayBombPlace();
                base.UseRight();
            }
        }

        public override void UseUp()
        {
            if (InventoryAgrees())
            {
                SoundManager.Instance.PlayBombPlace();
                base.UseUp();
            }
        }

        public override void UseDown()
        {
            if (InventoryAgrees())
            {
                SoundManager.Instance.PlayBombPlace();
                base.UseDown();
            }
        }
    }
}
