using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IProjectile : IGameObject
    {
        void Fire(Vector2 direction, Vector2 startPosition);
    }
}
