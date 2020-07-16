namespace Sprint2
{
    public class Wallmaster : AbstractNPC
    {
        private ILink link;

        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.EnemyGround;

        public Wallmaster()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyWallmasterLeft();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.WallmasterDamageAmount;
            MaxHP = Constant.WallmasterHP;
            CurrentHP = MaxHP;

            link = Game1.Instance.Link;
        }

        public override void Update()
        {
            MoveWallmaster();
            base.Update();
        }

        private void MoveWallmaster()
        {
            //Very complicated movement
        }
    }
}
