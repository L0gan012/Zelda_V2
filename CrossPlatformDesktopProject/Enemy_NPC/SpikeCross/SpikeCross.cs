namespace Sprint2
{
    public class SpikeCross : AbstractNPC
    {
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public SpikeCross()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemySpikeCross();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.SpikeCrossDamageAmount;
            MaxHP = Constant.SpikeCrossHP;
            CurrentHP = MaxHP;
        }
    }
}
