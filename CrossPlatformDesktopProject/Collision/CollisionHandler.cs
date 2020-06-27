using System.Collections.Generic;

namespace Sprint2.Collision
{
    class CollisionHandler
    {


        public CollisionHandler(List<ICollisionEvent> collisionEvents)
        {
            if(collisionEvents != null)
            {
                foreach (ICollisionEvent collisionEvent in collisionEvents)
                {
                    //TODO: Figure out how to make this work.
                }

            }
        }

        //Player Vs Enemy
        //Player Vs Projectiles
        //Player Vs Blocks
        //Player Vs Item


        //Enemy Vs Projectiles
        //Enemy Vs Blocks
        
        //Projectiles Vs Blocks
        //Projectiles Vs Items



        // intersectionRectangle = Rectangle.Intersect(gameObject1.Rectangle, gameObject2.Rectangle);
    }
}
