
namespace Sprint2
{
    public abstract class AbstractUsableMoving : AbstractUsable
    {
        protected float DeltaX { get; set; }
        protected float DeltaY { get; set; }

        public override void UseLeft()
        {
            base.UseLeft();
            
            DeltaX = -1;
            DeltaY = 0;
        }

        public override void UseRight()
        {
            base.UseRight();

            DeltaX = 1;
            DeltaY = 0;
        }

        public override void UseUp()
        {
            base.UseUp();

            DeltaX = 0;
            DeltaY = -1;
        }

        public override void UseDown()
        {
            base.UseDown();

            DeltaX = 0;
            DeltaY = 1;
        }
    }
}
