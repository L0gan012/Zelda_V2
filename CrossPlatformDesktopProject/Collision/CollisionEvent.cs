using Microsoft.Xna.Framework;
using Sprint2.Interfaces;
using System;

namespace Sprint2.Collision
{
    class CollisionEvent : ICollisionEvent
    {
        Tuple<IGameObject, IGameObject, Rectangle> collisionEvent;
        public CollisionEvent(IGameObject gameObject1, IGameObject gameObject2, Rectangle intersectionRectangle)
        {
            collisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);

        }
    }
}
