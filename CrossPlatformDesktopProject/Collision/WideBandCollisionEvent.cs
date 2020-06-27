using System;
using Microsoft.Xna.Framework;
using Sprint2.Interfaces;


namespace Sprint2.Collision
{
    class WideBandCollisionEvent : ICollisionEvent
    {
        Tuple<IGameObject, IGameObject, Rectangle> wideBandCollisionEvent;
        public WideBandCollisionEvent(IGameObject gameObject1, IGameObject gameObject2, Rectangle intersectionRectangle)
        {
            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
        }
    }
}
