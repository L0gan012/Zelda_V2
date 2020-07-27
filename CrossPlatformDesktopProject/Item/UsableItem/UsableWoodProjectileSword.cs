using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableWoodProjectileSword : AbstractUsableMoving
    {
        private Rectangle range;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UsableItemVsEnemy;  

        public UsableWoodProjectileSword(IGameObject user)
        {
            User = user;
            range = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
            DamageAmount = ItemConstants.SwordDamageAmount;
        }

        public override void Update()
        {
            Position += Velocity * ItemConstants.SwordBeamSpeed;
            
        if (!range.Contains(Center))
            {
                 IsDestructable = true;
                 //UsableWoodenSword.projectile = null;
                 UsableWoodenSword.IsMoving = false;
            }
          
            base.Update();
        }

        public override void UseLeft()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordLeft();
            SoundManager.Instance.PlaySwordShoot();
            
            UsableWoodenSword.IsMoving = true;
            base.UseLeft();
        }

        public override void UseRight()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordRight();
            SoundManager.Instance.PlaySwordShoot();
            UsableWoodenSword.IsMoving = true;
            base.UseRight();
        }

        public override void UseUp()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordUp();
            SoundManager.Instance.PlaySwordShoot();
            UsableWoodenSword.IsMoving = true;
            base.UseUp();
        }

        public override void UseDown()
        {
            Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenSwordDown();
            SoundManager.Instance.PlaySwordShoot();
            UsableWoodenSword.IsMoving = true;
            base.UseDown();
        }
    }
}
