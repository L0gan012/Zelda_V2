

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
        //Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide> collisionTypeKey;
        //List<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>> collisionTypeKeyList;
        List<Tuple<IGameObject, IGameObject, Enumerations.CollisionSide>> collisionEventList;
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> narrowBandEventList;





        public CollisionHandler(List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> narrowBandEventList)
        {
            this.narrowBandEventList = narrowBandEventList; ;

        }

        void GenerateCollisionEventKey()
        {
            if (narrowBandEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> narrowBandEvent in narrowBandEventList)
                {
                    gameObject1 = narrowBandEvent.Item1;
                    gameObject2 = narrowBandEvent.Item2;
                    intersectionRectangle = narrowBandEvent.Item3;
                    sideOfCollisionObject1 = narrowBandEvent.Item4;
                    Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide> collisionTypeKey = new Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>(gameObject1.GameObjectType, gameObject2.GameObjectType, sideOfCollisionObject1);
                   // Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>

                }
            }

        void CorrectHorizontal()
        {
            if (narrowBandEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> narrowBandEvent in narrowBandEventList)
                {
                    gameObject1 = narrowBandEvent.Item1;
                    gameObject2 = narrowBandEvent.Item2;
                    intersectionRectangle = narrowBandEvent.Item3;
                    sideOfCollisionObject1 = narrowBandEvent.Item4;
                    
                        if(sideOfCollisionObject1.Equals(Enumerations.CollisionSide.Left ))
                        {
                            gameObject1.Position = new Vector2(gameObject1.Position.X + intersectionRectangle.X, gameObject1.Position.Y);
                        }

                        if(sideOfCollisionObject1.Equals(Enumerations.CollisionSide.Left))
                        {
                            gameObject1.Position = new Vector2(gameObject1.Position.X - intersectionRectangle.X, gameObject1.Position.Y);
                        }
                    
                }
            }
        }

            void CorrectVertical()
            {
                if (narrowBandEventList != null)
                {
                    foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> narrowBandEvent in narrowBandEventList)
                    {
                        gameObject1 = narrowBandEvent.Item1;
                        gameObject2 = narrowBandEvent.Item2;
                        intersectionRectangle = narrowBandEvent.Item3;
                        sideOfCollisionObject1 = narrowBandEvent.Item4;

                        if (sideOfCollisionObject1.Equals(Enumerations.CollisionSide.Top))
                        {
                            gameObject1.Position = new Vector2(gameObject1.Position.X, gameObject1.Position.Y + intersectionRectangle.Y);
                        }

                        if (sideOfCollisionObject1.Equals(Enumerations.CollisionSide.Bottom))
                        {
                            gameObject1.Position = new Vector2(gameObject1.Position.X, gameObject1.Position.Y - intersectionRectangle.Y);
                        }

                    }
                }
            }




        }

    }
}
