using System.Collections.Generic;
using Microsoft.Xna.Framework;


namespace Sprint2.Collision
{
    class CollisionDetector
    {
        CollisionEvent collisionEvent;
        List<CollisionEvent> collisionEvents;
        Rectangle intersectionRectangle;

        public void CheckForCollision(List<IGameObject> gameObjects1, List<IGameObject> gameObjects2)
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
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }

            }
        }
    }
}
