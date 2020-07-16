using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IProjectile : IGameObject
    {
        float DamageAmount { get; }

        void Fire(Vector2 direction, Vector2 startPosition);
    }
}
