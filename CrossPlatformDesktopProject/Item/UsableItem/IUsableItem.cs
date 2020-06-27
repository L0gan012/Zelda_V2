using Microsoft.Xna.Framework;

namespace Sprint2
{
    public interface IUsableItem : IItem
    {
        float DamageAmount { get; }

        Vector2 Velocity { get; set; }

        void UseLeft();

        void UseRight();

        void UseDown();

        void UseUp();
    }
}
