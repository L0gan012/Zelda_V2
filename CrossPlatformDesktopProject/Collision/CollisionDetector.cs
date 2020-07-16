using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class CollisionDetector
    {

        IGameObject gameObject1;
        IGameObject gameObject2;
        Rectangle intersectionRectangle;
        Enumerations.CollisionSide collisionSideObject1;

        List<Tuple<IGameObject, IGameObject, Rectangle>> collisionRectangleEventList;
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionSideEventList;
        

        public CollisionDetector()
        {
    
        }

        public void Update(List<IPlayer> playerObjectList, List<INPC> enemyObjectList, List<IProjectile> projectileObjectList, List<IBlock> blockObjectList, 
            List<IItem> itemObjectList, List<IUsableItem> usableItemObjectList)
        {


            collisionRectangleEventList = new List<Tuple<IGameObject, IGameObject, Rectangle>>();
            GetAllCollisionRectangles(playerObjectList, enemyObjectList, projectileObjectList, blockObjectList, itemObjectList, usableItemObjectList);
 

            if (collisionRectangleEventList != null)
            {
                collisionSideEventList = new List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>>();
                collisionSideEventList = CollisionSideDetect();
            }
            CollisionHandler collisionHandler = new CollisionHandler(collisionSideEventList);
            collisionHandler.Update();



        }





        public void GetAllCollisionRectangles(List<IPlayer> playerObjectList, List<INPC> enemyObjectList, List<IProjectile> projectileObjectList,
            List<IBlock> blockObjectList, List<IItem> itemObjectList, List<IUsableItem> usableItemObjectList)
        {



            if (playerObjectList != null && enemyObjectList != null)
            {
                CollisionRectangleDetect(playerObjectList.Cast<IGameObject>().ToList(), enemyObjectList.Cast<IGameObject>().ToList());
            }

            if (playerObjectList != null && projectileObjectList != null)
            {
                CollisionRectangleDetect(playerObjectList.Cast<IGameObject>().ToList(), projectileObjectList.Cast<IGameObject>().ToList());
            }

            if (playerObjectList != null && usableItemObjectList != null)
            {
                CollisionRectangleDetect(playerObjectList.Cast<IGameObject>().ToList(), usableItemObjectList.Cast<IGameObject>().ToList());
            }

            if (playerObjectList != null && blockObjectList != null)
            {
                CollisionRectangleDetect(playerObjectList.Cast<IGameObject>().ToList(), blockObjectList.Cast<IGameObject>().ToList());
            }

            if (playerObjectList != null && itemObjectList != null)
            {
                CollisionRectangleDetect(playerObjectList.Cast<IGameObject>().ToList(), itemObjectList.Cast<IGameObject>().ToList());
            }

            if (enemyObjectList != null && usableItemObjectList != null)
            {
                CollisionRectangleDetect(enemyObjectList.Cast<IGameObject>().ToList(), usableItemObjectList.Cast<IGameObject>().ToList());
            }

            if (enemyObjectList != null && projectileObjectList != null)
            {
                CollisionRectangleDetect(enemyObjectList.Cast<IGameObject>().ToList(), projectileObjectList.Cast<IGameObject>().ToList());
            }

            if (enemyObjectList != null && blockObjectList != null)
            {
                CollisionRectangleDetect(enemyObjectList.Cast<IGameObject>().ToList(), blockObjectList.Cast<IGameObject>().ToList());
            }

            if (usableItemObjectList != null && blockObjectList != null)
            {
                CollisionRectangleDetect(usableItemObjectList.Cast<IGameObject>().ToList(), blockObjectList.Cast<IGameObject>().ToList());
            }

            if (usableItemObjectList != null && itemObjectList != null)
            {
                CollisionRectangleDetect(usableItemObjectList.Cast<IGameObject>().ToList(), itemObjectList.Cast<IGameObject>().ToList());
            }
            if (projectileObjectList != null && blockObjectList != null)
            {
                CollisionRectangleDetect(projectileObjectList.Cast<IGameObject>().ToList(), blockObjectList.Cast<IGameObject>().ToList());
            }

            if (projectileObjectList != null && itemObjectList != null)
            {
                CollisionRectangleDetect(projectileObjectList.Cast<IGameObject>().ToList(), itemObjectList.Cast<IGameObject>().ToList());
            }
        }

        public void CollisionRectangleDetect(List<IGameObject> gameObjectList1, List<IGameObject> gameObjectList2)
        {
            if (gameObjectList1 != null && gameObjectList2 != null)
            {
                foreach (IGameObject gameObject1 in gameObjectList1)
                {
                    foreach (IGameObject gameObject2 in gameObjectList2)
                    {
                        if (gameObject1.Rectangle.Intersects(gameObject2.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(gameObject1.Rectangle, gameObject2.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                System.Diagnostics.Debug.WriteLine("Collision!");
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> CollisionSideDetect()
        {
            if (collisionRectangleEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle> closeProximityEvent in collisionRectangleEventList)
                {
                    gameObject1 = closeProximityEvent.Item1;
                    gameObject2 = closeProximityEvent.Item2;
                    intersectionRectangle = closeProximityEvent.Item3;
                    collisionSideObject1 = Enumerations.CollisionSide.None;


                    if(intersectionRectangle.Width >= intersectionRectangle.Height)
                    {
                        if(gameObject1.Center.Y < gameObject2.Center.Y)
                        {
                            collisionSideObject1 = Enumerations.CollisionSide.Bottom;
                        }
                        else
                        {
                            collisionSideObject1 = Enumerations.CollisionSide.Top;
                        }
                    }
                    else
                    {
                        if (gameObject1.Center.X < gameObject2.Center.X)
                        {
                            collisionSideObject1 = Enumerations.CollisionSide.Right;
                        }
                        else
                        {
                            collisionSideObject1 = Enumerations.CollisionSide.Left;
                        }
                    }
                    Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> collisionSideEvent
                        = new Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>(gameObject1, gameObject2, intersectionRectangle, collisionSideObject1);
                     collisionSideEventList.Add(collisionSideEvent);
                }

            }
            return collisionSideEventList;
        }

    }
}
