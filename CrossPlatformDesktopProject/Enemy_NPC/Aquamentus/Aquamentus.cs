using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Aquamentus : AbstractNPC
    {
        private ISprite projectile;
        private bool left;
        private float limit;
        private int deltaX;
        private float prevX;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }



        public Aquamentus()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyAquamentus();
            Position = Constant.EnemyStartPosition;
            Color = Color.White;
            DamageAmount = Constant.AquamentusDamageAmount;
            maxHP = Constant.AquamentusHP;
            currentHP = maxHP;
           
            left = true;
            deltaX = -1;
            limit = Constant.RNG.Next(Constant.MinAquamentusXRange, Constant.MaxAquamentusXRange);
            prevX = Position.X;
        }

        public override void Update()
        {
            Position = new Vector2(Position.X + deltaX * Constant.AquamentusSpeed, Position.Y);

            if(Math.Abs(Position.X - prevX) > limit)
            {
                left = !left;
                deltaX = -deltaX;
                limit = Constant.RNG.Next(Constant.MinAquamentusXRange, Constant.MaxAquamentusXRange);
                prevX = Position.X;
            }

            Sprite.Update();


        }
    }
}
