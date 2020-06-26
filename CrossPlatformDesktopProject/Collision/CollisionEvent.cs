using System;

namespace Sprint2
{
    class CollisionEvent : ICollisionEvent
    {
        Tuple<IGameObject, IGameObject> collisionEvent;
        public CollisionEvent(IGameObject gameObject1, IGameObject gameObject2)
        {
            collisionEvent = new Tuple<IGameObject, IGameObject>(gameObject1, gameObject2);

        }
    }
}
