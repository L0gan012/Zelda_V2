using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Dodongo : AbstractNPC
    {
        public IDodongoState State { get; set; }
        private float limit;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Dodongo()
        {
            State = new RightMovingDodongoState(this);

            DamageAmount = Constant.DodongoDamageAmount;
            maxHP = Constant.DodongoHP;
            currentHP = maxHP;
        }

        public override void Update()
        {
            State.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            State.Draw(spriteBatch);
        }

        public void BePuffed()
        {
            State.BePuffed();
        }

        public void MoveDown()
        {
            //State.MoveDown();
        }

        public void MoveLeft()
        {
            //State.MoveLeft();
        }

        public void MoveRight()
        {
            //State.MoveRight();
        }

        public void MoveUp()
        {
            //State.MoveUp();
        }
    }
}
