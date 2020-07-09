using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Goriya : AbstractNPC
    {
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public Goriya()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyGoriyaWalkDown();
            Position = Constant.EnemyStartPosition;
            Color = Color.White;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
