namespace Sprint2
{
    public class Zol : AbstractNPC
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public Zol()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyZol();
            Position = Constant.EnemyStartPosition;

            DamageAmount = EnemyConstants.ZolDamageAmount;
            MaxHP = EnemyConstants.ZolHP;
            CurrentHP = MaxHP;
        }
    }
}
