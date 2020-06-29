using System;

namespace Sprint2
{
    class CollisionKey
    {

        Enumerations.CollisionSide collisionSideObject1;
        Tuple<IGameObject, IGameObject, Enumerations.CollisionSide> collisionKey;
        public CollisionKey(IGameObject gameObject1, IGameObject gameObject2, Enumerations.CollisionSide collisionSideObject1)
        {
            collisionKey = new Tuple<IGameObject, IGameObject, Enumerations.CollisionSide>(gameObject1, gameObject2, collisionSideObject1);
        }
    }
}
