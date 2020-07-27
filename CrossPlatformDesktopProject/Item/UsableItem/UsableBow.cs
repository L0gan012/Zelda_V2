using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class UsableBow : AbstractUsableMoving
    {
        private Rectangle range;
        private IPlayer link;

        public Enumerations.ArrowType Type { get; set; }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.UsableItemVsEnemy;

        public UsableBow(IPlayer user)
        {
            User = user;
            InventoryPosition = new Vector2(HUDConstants.BowAndArrowInventoryPosition.X, HUDConstants.BowAndArrowInventoryPosition.Y);
            DamageAmount = ItemConstants.ArrowDamageAmount;

            link = user;
            range = new Rectangle(0, 0, Constant.ScreenWidth, Constant.ScreenHeight);
        }

        public override void Update()
        {
            Position += Velocity * ItemConstants.ArrowSpeed;

            if (!range.Contains(Center))
            {
                IsDestructable = true;
            }

            base.Update();
        }

        private bool InventoryAgrees()
        {
            bool canUseArrows = link.Inventory.HasArrows && link.Inventory.RupeeCount > 0;
            if (canUseArrows)
            {
                link.Inventory.RupeeCount--;
            }
            return canUseArrows;
        }


        public override void UseLeft()
        {
            if (InventoryAgrees())
            {
                switch (Type)
                {
                    case Enumerations.ArrowType.wooden:
                        Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowLeft();
                        break;
                    case Enumerations.ArrowType.silver:
                        Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowLeft();
                        break;
                    default:
                        break;
                }
                base.UseLeft();
            }
        }

        public override void UseRight()
        {
            if (InventoryAgrees())
            {
                switch (Type)
                {
                    case Enumerations.ArrowType.wooden:
                        Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowRight();
                        break;
                    case Enumerations.ArrowType.silver:
                        Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowRight();
                        break;
                    default:
                        break;
                }
                base.UseRight();
            }
        }

        public override void UseUp()
        {
            if (InventoryAgrees())
            {
                switch (Type)
                {
                    case Enumerations.ArrowType.wooden:
                        Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowUp();
                        break;
                    case Enumerations.ArrowType.silver:
                        Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowUp();
                        break;
                    default:
                        break;
                }
                base.UseUp();
            }
        }

        public override void UseDown()
        {
            if (InventoryAgrees())
            {
                switch (Type)
                {
                    case Enumerations.ArrowType.wooden:
                        Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileWoodenArrowDown();
                        break;
                    case Enumerations.ArrowType.silver:
                        Sprite = ProjectileSpriteFactory.Instance.CreateSpriteProjectileSilverArrowDown();
                        break;
                    default:
                        break;
                }
                base.UseDown();
            }
        }
    }
}
