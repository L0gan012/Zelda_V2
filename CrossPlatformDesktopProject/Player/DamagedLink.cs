using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics.Eventing.Reader;

namespace Sprint2.Player
{
    public class DamagedLink : ILink
    {
        private static Game1 game;
        private ILink link;

        private int timer;

        public Color Color { get => link.Color; set => link.Color = value; }
        public Vector2 Position { get => link.Position; set => link.Position = value; }
        public ILinkState State { get => link.State; set => link.State = value; }
        public IUsableItem Item { get => link.Item; set => link.Item = value; }

        public DamagedLink(ILink link, Game1 game)
        {
            DamagedLink.game = game;
            this.link = link;

            timer = Constant.DamagedTime;
        }

        public void Update()
        {
            timer--;
            if(timer > 3*Constant.DamagedTime/4)
            {
                Color = Color.Blue;
            } else if(timer > 2*Constant.DamagedTime/4)
            {
                Color = Color.Red;
            } else if(timer > Constant.DamagedTime/4)
            {
                Color = Color.Green;
            } else
            {
                Color = Color.Purple;
            }

            if(timer == 0)
            {
                RemoveDecorator();
            }
            link.Update();
        }

        public void RemoveDecorator()
        {
            Color = Color.White;
            game.Link = link;
        }

        public void Draw(SpriteBatch spriteBatch)
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
    }
}