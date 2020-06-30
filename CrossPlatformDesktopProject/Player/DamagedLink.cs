using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class DamagedLink : AbstractGameObject, ILink
    {
        private ILink link;
        private int timer;

        public override Enumerations.GameObjectType GameObjectType
        {
            get => link.GameObjectType;
            set => _ = link.GameObjectType;
        }
        public float MaxHP { get => link.MaxHP; set => link.MaxHP = value; }
        public float HP { get => link.HP; set => link.HP = value; }
        public Enumerations.Sides FacingDirection { get => link.FacingDirection; set => link.FacingDirection = value; }
        public ILinkState State { get => link.State; set => link.State = value; }
        public IUsableItem PrimaryItem { get => link.PrimaryItem; set => link.PrimaryItem = value; }
        public IUsableItem SecondaryItem { get => link.SecondaryItem; set => link.SecondaryItem = value; }
        public override ISprite Sprite { get => link.Sprite; }

        public DamagedLink(ILink link)
        {
            this.link = link;

            timer = Constant.DamagedTime;
        }

        public override void Update()
        {
            timer--;
            if(timer > 3*Constant.DamagedTime/4)
            {
                link.Color = Color.Blue;
            } else if(timer > 2*Constant.DamagedTime/4)
            {
                link.Color = Color.Red;
            } else if(timer > Constant.DamagedTime/4)
            {
                link.Color = Color.Green;
            } else
            {
                link.Color = Color.Purple;
            }

            if(timer == 0)
            {
                RemoveDecorator();
            }
            link.Update();
        }

        public void RemoveDecorator()
        {
            link.Color = Color.White;
            Game1.Instance.Link = link;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            link.Draw(spriteBatch);
        }

        public void DamagePlayer()
        {
            //Doesn't take damage
        }

        public void UseItem()
        {
            link.UseItem();
        }

        public void SetIdle()
        {
            link.SetIdle();
        }

        public void MoveLeft()
        {
            link.MoveLeft();
        }

        public void MoveRight()
        {
            link.MoveRight();
        }

        public void MoveUp()
        {
            link.MoveUp();
        }

        public void MoveDown()
        {
            link.MoveDown();
        }

        public void Attack()
        {
            link.Attack();
        }

        public void DamagePlayer(float damageAmount)
        {
            link.DamagePlayer(damageAmount);
        }
    }
}