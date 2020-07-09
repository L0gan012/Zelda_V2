namespace Sprint2
{
    public class Wallmaster : AbstractNPC
    {
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public Wallmaster()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyWallmasterLeft();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.WallmasterDamageAmount;
            MaxHP = Constant.WallmasterHP;
            CurrentHP = MaxHP;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
