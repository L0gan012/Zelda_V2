using Microsoft.Xna.Framework;
using Sprint2.Interfaces;
using System;

namespace Sprint2.Collision
{
    class CollisionEvent : ICollisionEvent
    {

        Enumerations.CollisionSide collisionSideObject1;
        Tuple<IGameObject, IGameObject, Enumerations.CollisionSide> collisionEvent;
        public CollisionEvent(IGameObject gameObject1, IGameObject gameObject2, Enumerations.CollisionSide collisionSideObject1)
        {
            collisionEvent = new Tuple<IGameObject, IGameObject, Enumerations.CollisionSide>(gameObject1, gameObject2, collisionSideObject1);
        }
    }
}
