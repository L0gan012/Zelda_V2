using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Link : ILink
    {
        private static Game1 game;

        public Color Color { get; set; }
        public Vector2 Position { get; set; }
        public ILinkState State { get; set; }
        public IUsableItem PrimaryItem { get; set; }
        public IUsableItem SecondaryItem { get; set; }

        public Vector2 Center
        {
            get {
                float x = Position.X + State.Sprite.GetWidth() / 2.0f;
                float y = Position.Y + State.Sprite.GetHeight() / 2.0f;

                return new Vector2(x, y);
            }
        }

        public Link(Game1 game)
        {
            Link.game = game;
            Position = Constant.LinkStartPosition;

            State = new IdleLinkDownState(this);
            Color = Color.White;
        }

        public void Update()
        {
            if(PrimaryItem != null)
            {
                PrimaryItem.Update();
            }
            if (SecondaryItem != null)
            {
                SecondaryItem.Update();
            }
            State.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(PrimaryItem != null)
            {
                PrimaryItem.Draw(spriteBatch);
            }
            if (SecondaryItem != null)
            {
                SecondaryItem.Draw(spriteBatch);
            }
            State.Draw(spriteBatch, Color);
        }

        public void DamagePlayer() 
        {
            State.DamageLink(game);
        }

        public void UseItem() 
        {
            State.UseItem();
        }

        public void SetIdle()
        {
            State.SetLinkIdle();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void MoveLeft()
        {
            State.MoveLinkLeft();
        }

        public void MoveRight()
        {
            State.MoveLinkRight();
        }

        public void MoveUp()
        {
            State.MoveLinkUp();
        }

        public void MoveDown()
        {
            State.MoveLinkDown();
        }
    }
}