using System;
using Microsoft.Xna.Framework;
using Sprint2.Interfaces;


namespace Sprint2.Collision
{
    class NarrowBandCollisionEvent : ICollisionEvent
    {
        Tuple<IGameObject, IGameObject, Enumerations.CollisionSide> narrowBandCollisionEvent;

        public NarrowBandCollisionEvent(IGameObject gameObject1, IGameObject gameObject2, Enumerations.CollisionSide collisionSideObject1)
        {
            narrowBandCollisionEvent = new Tuple<IGameObject, IGameObject, Enumerations.CollisionSide>(gameObject1, gameObject2, collisionSideObject1);
        }
    }
}
