using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Sprint2.Interfaces;


namespace Sprint2.Collision
{
    class CollisionDetector
    {
        ICollisionEvent collisionEvent;
        List<ICollisionEvent> collisionEvents;
        Rectangle intersectionRectangle;

        public CollisionDetector(List<IGameObject> gameObjects1, List<IGameObject> gameObjects2)
        {

            if (gameObjects1 != null && gameObjects2 != null)
            {
                foreach (IGameObject gameObject1 in gameObjects1)
                {
                    foreach (IGameObject gameObject2 in gameObjects2)
                    {
                        if (gameObject1.GetRectangle().Intersects(gameObject2.GetRectangle()))
                        {
                            intersectionRectangle = Rectangle.Intersect(gameObject1.GetRectangle(), gameObject2.GetRectangle());
                            collisionEvent = new CollisionEvent(gameObject1, gameObject2, intersectionRectangle);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }

            }
        }
    }
}
