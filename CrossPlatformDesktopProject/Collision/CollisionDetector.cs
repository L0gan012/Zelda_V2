﻿using System;
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






        //TODO: I might be able to  cast these and avoid overloading altogether.  


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

/*


        public void CollisionRectangleDetect(List<IPlayer> playerObjectList, List<INPC> enemyObjectList)
        {
            if (playerObjectList != null && enemyObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (INPC enemyObject in enemyObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(enemyObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(playerObject.Rectangle, enemyObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                System.Diagnostics.Debug.WriteLine("Link Meets A BadGuy");
                                gameObject1 = (IGameObject)playerObject;
                                gameObject2 = (IGameObject)enemyObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }




        public void CollisionRectangleDetect(List<IPlayer> playerObjectList, List<IUsableItem> usableItemObjectList)
        {
            if (playerObjectList != null && usableItemObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (IUsableItem usableItemObject in usableItemObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(usableItemObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(playerObject.Rectangle, usableItemObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                System.Diagnostics.Debug.WriteLine("Link Meets UsableItem");
                                gameObject1 = (IGameObject)playerObject;
                                gameObject2 = (IGameObject)usableItemObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<IPlayer> playerObjectList, List<IProjectile> projectileObjectList)
        {
            if (playerObjectList != null && projectileObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (IProjectile projectileObject in projectileObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(projectileObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(playerObject.Rectangle, projectileObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                System.Diagnostics.Debug.WriteLine("Link Meets Projectile");
                                gameObject1 = (IGameObject)playerObject;
                                gameObject2 = (IGameObject)projectileObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<IPlayer> playerObjectList, List<IBlock> blockObjectList)
        {
            if (playerObjectList != null && blockObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (IBlock blockObject in blockObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(blockObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(playerObject.Rectangle, blockObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                System.Diagnostics.Debug.WriteLine("Link Meets Brick");
                                gameObject1 = (IGameObject)playerObject;
                                gameObject2 = (IGameObject)blockObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<IPlayer> playerObjectList, List<IItem> itemObjectList)
        {
            if (playerObjectList != null && itemObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (IItem itemObject in itemObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(itemObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(playerObject.Rectangle, itemObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                gameObject1 = (IGameObject)playerObject;
                                gameObject2 = (IGameObject)itemObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<INPC> enemyObjectList, List<IUsableItem> usableItemObjectList)
        {
            if (enemyObjectList != null && usableItemObjectList != null)
            {
                foreach (INPC enemyObject in enemyObjectList)
                {
                    foreach (IUsableItem usableItemObject in usableItemObjectList)
                    {
                        if (enemyObject.Rectangle.Intersects(usableItemObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(enemyObject.Rectangle, usableItemObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                gameObject1 = (IGameObject)enemyObject;
                                gameObject2 = (IGameObject)usableItemObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<INPC> enemyObjectList, List<IProjectile> projectileObjectList)
        {
            if (enemyObjectList != null && projectileObjectList != null)
            {
                foreach (INPC enemyObject in enemyObjectList)
                {
                    foreach (IProjectile projectileObject in projectileObjectList)
                    {
                        if (enemyObject.Rectangle.Intersects(projectileObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(enemyObject.Rectangle, projectileObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                gameObject1 = (IGameObject)enemyObject;
                                gameObject2 = (IGameObject)projectileObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }



        public void CollisionRectangleDetect(List<INPC> enemyObjectList, List<IBlock> blockObjectList)
        {
            if (enemyObjectList != null && blockObjectList != null)
            {
                foreach (INPC enemyObject in enemyObjectList)
                {
                    foreach (IBlock blockObject in blockObjectList)
                    {
                        if (enemyObject.Rectangle.Intersects(blockObject.Rectangle))
                        {
                            if (intersectionRectangle != null)
                            {
                                gameObject1 = (IGameObject)enemyObject;
                                gameObject2 = (IGameObject)blockObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<IUsableItem> usableItemObjectList, List<IBlock> blockObjectList)
        {
            if (usableItemObjectList != null && blockObjectList != null)
            {
                foreach (IUsableItem usableItemObject in usableItemObjectList)
                {
                    foreach (IBlock blockObject in blockObjectList)
                    {
                        if (usableItemObject.Rectangle.Intersects(blockObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(usableItemObject.Rectangle, blockObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                gameObject1 = (IGameObject)usableItemObject;
                                gameObject2 = (IGameObject)blockObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<IUsableItem> usableItemObjectList, List<IItem> itemObjectList)
        {
            if (usableItemObjectList != null && itemObjectList != null)
            {
                foreach (IUsableItem usableItemObject in usableItemObjectList)
                {
                    foreach (IItem itemObject in itemObjectList)
                    {
                        if (usableItemObject.Rectangle.Intersects(itemObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(usableItemObject.Rectangle, itemObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                gameObject1 = (IGameObject)usableItemObject;
                                gameObject2 = (IGameObject)itemObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<IProjectile> projectileObjectList, List<IBlock> blockObjectList)
        {
            if (projectileObjectList != null && blockObjectList != null)
            {
                foreach (IProjectile projectileObject in projectileObjectList)
                {
                    foreach (IBlock blockObject in blockObjectList)
                    {
                        if (projectileObject.Rectangle.Intersects(blockObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(projectileObject.Rectangle, blockObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                gameObject1 = (IGameObject)projectileObject;
                                gameObject2 = (IGameObject)blockObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }

        public void CollisionRectangleDetect(List<IProjectile> projectileObjectList, List<IItem> itemObjectList)
        {
            if (projectileObjectList != null && itemObjectList != null)
            {
                foreach (IProjectile projectileObject in projectileObjectList)
                {
                    foreach (IItem itemObject in itemObjectList)
                    {
                        if (projectileObject.Rectangle.Intersects(itemObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(projectileObject.Rectangle, itemObject.Rectangle);
                            if (intersectionRectangle != null)
                            {
                                gameObject1 = (IGameObject)projectileObject;
                                gameObject2 = (IGameObject)itemObject;
                                Tuple<IGameObject, IGameObject, Rectangle> collisionRectangleEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                collisionRectangleEventList.Add(collisionRectangleEvent);
                            }
                        }
                    }
                }
            }
        }


        */


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
