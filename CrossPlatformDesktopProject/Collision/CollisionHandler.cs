

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace Sprint2.Collision
{
    class CollisionHandler
    {
        IGameObject gameObject1;
        IGameObject gameObject2;
        Rectangle intersectionRectangle;
        Enumerations.CollisionSide sideOfCollisionObject1;
        Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide> collisionType;
        List<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>> collisionTypeList;
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEventList;


        public CollisionHandler(List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionEventList)
        {
            this.collisionEventList = collisionEventList;
        }


        void CorrectPosition()
        {
            if (collisionEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> collisionEvent in collisionEventList)
                {
                    gameObject1 = collisionEvent.Item1;
                    gameObject2 = collisionEvent.Item2;
                    intersectionRectangle = collisionEvent.Item3;
                    sideOfCollisionObject1 = collisionEvent.Item4;

                }
            }
        }


        void DirectCollisionToHandler()
        { 
            if(collisionEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> collisionEvent in collisionEventList)
                {
                    gameObject1 = collisionEvent.Item1;
                    gameObject2 = collisionEvent.Item2;
                    intersectionRectangle = collisionEvent.Item3;
                    sideOfCollisionObject1 = collisionEvent.Item4;
                    collisionType = new Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>(gameObject1.GameObjectType, gameObject2.GameObjectType, sideOfCollisionObject1);



                






                }

            }
        }

    }
}
