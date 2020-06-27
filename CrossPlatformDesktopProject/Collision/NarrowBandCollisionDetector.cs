using Sprint2.Interfaces;
using System.Collections.Generic;
using Microsoft.Xna.Framework;


namespace Sprint2.Collision
{
    class NarrowBandCollisionDetector
    {
        WideBandCollisionEvent wideBandCollisionEvent;
        List<ICollisionEvent> collisionEvents;
        Rectangle intersectionRectangle;

        public NarrowBandCollisionDetector(WideBandCollisionEvent wideBandCollisionEvent)
        {

        }
    }
}
