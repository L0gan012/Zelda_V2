using Microsoft.Xna.Framework;
namespace Sprint2
{
    public abstract class AbstractUsableMoving : AbstractUsable
    {

        public override void UseLeft()
        {
            base.UseLeft();
            Velocity = new Vector2(-1, 0);
        }

        public override void UseRight()
        {
            base.UseRight();
            Velocity = new Vector2(1, 0);
        }

        public override void UseUp()
        {
            base.UseUp();
            Velocity = new Vector2(0, -1);
        }

        public override void UseDown()
        {
            base.UseDown();
            Velocity = new Vector2(0, 1);
        }
    }
}
