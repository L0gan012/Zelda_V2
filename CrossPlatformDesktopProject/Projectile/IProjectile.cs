using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public interface IProjectile : IGameObject
    {

        bool IsVsEnemy { get; set; }

        bool IsVsPlayer { get; set; }

        bool IsReturnToSender { get; }

        bool IsLimitToOne { get; }

        bool IsAbleToBreakWalls { get; }

        int ParalysisDuration { get; }

        int Damage { get; set; }

        Vector2 Heading { get; set; }

        int Velocity { get; set; }

        int Knockback { get; }




        void Update();


        void Draw(SpriteBatch spriteBatch);

        Rectangle GetRectangle();
    }
}
