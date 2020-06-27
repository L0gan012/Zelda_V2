using Microsoft.Xna.Framework;

namespace Sprint2
{
    public interface IUsableItem : IItem
    {
        int DamageAmount { get; set; }

        Vector2 Velocity { get; set; }

        void UseLeft();

        void UseRight();

        void UseDown();

        void UseUp();
    }
}
