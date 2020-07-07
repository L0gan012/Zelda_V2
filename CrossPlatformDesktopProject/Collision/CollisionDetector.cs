using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;


namespace Sprint2.Collision
{
    public class CollisionDetector
    {

        IGameObject gameObject1;
        IGameObject gameObject2;
        Tuple<IGameObject, IGameObject, Rectangle> intersectionEvent;
        List<Tuple<IGameObject, IGameObject, Rectangle>> intersectionEventList;
        Rectangle intersectionRectangle;
        Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> intersectionWithSideEvent;
        public List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> intersectionWithSideEventList {get; set;}
        Enumerations.CollisionSide sideOfCollisionObject1;

        public CollisionDetector()
        {
            intersectionWithSideEventList = new List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>>();
        }

        public void Update(List<IPlayer> playerObjectList, List<INPC> enemyObjectList, List<IProjectile> projectileObjectList, List<IBlock> blockObjectList, List<IItem> itemObjectList, List<IUsableItem> usableItemObjectList)
        {
            intersectionEventList = new List<Tuple<IGameObject, IGameObject, Rectangle>>();

            if (playerObjectList != null && enemyObjectList != null)
            {   
                IntersectionDetect(playerObjectList, enemyObjectList);
            }

            if (playerObjectList != null && projectileObjectList != null)
            {
                IntersectionDetect(playerObjectList, projectileObjectList);
            }

            if (playerObjectList != null && usableItemObjectList != null)
            {
                IntersectionDetect(playerObjectList, usableItemObjectList);
            }

            if (playerObjectList != null && blockObjectList != null)
            {
                IntersectionDetect(playerObjectList, blockObjectList);
            }

            if (playerObjectList != null && itemObjectList != null)
            {
                IntersectionDetect(playerObjectList, itemObjectList);
            }

            if (enemyObjectList != null && usableItemObjectList != null)
            {
                IntersectionDetect(enemyObjectList, usableItemObjectList);
            }

            if (enemyObjectList != null && projectileObjectList != null)
            {
                IntersectionDetect(enemyObjectList, projectileObjectList);
            }

            if (enemyObjectList != null && blockObjectList != null)
            {
                IntersectionDetect(enemyObjectList, blockObjectList);
            }

            if (usableItemObjectList != null && blockObjectList != null)
            {
                IntersectionDetect(usableItemObjectList, blockObjectList);
            }

            if (usableItemObjectList != null && itemObjectList != null)
            {
                IntersectionDetect(usableItemObjectList, itemObjectList);
            }
            if (projectileObjectList != null && blockObjectList != null)
            {
                IntersectionDetect(projectileObjectList, blockObjectList);
            }

            if (projectileObjectList != null && itemObjectList != null)
            {
                IntersectionDetect(projectileObjectList, itemObjectList);
            }

            if (intersectionEventList != null)
            {
                intersectionWithSideEventList = new List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>>();
                intersectionWithSideEventList = IntersectionWithSideDetect();
            }
            CollisionHandler collisionHandler = new CollisionHandler(intersectionWithSideEventList);
            collisionHandler.Update();



        }


        //TODO: I might be able to  cast these and avoid overloading altogether.  


        public void IntersectionDetect(List<IPlayer> playerObjectList, List<INPC> enemyObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<IPlayer> playerObjectList, List<IUsableItem> usableItemObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<IPlayer> playerObjectList, List<IProjectile> projectileObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<IPlayer> playerObjectList, List<IBlock> blockObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<IPlayer> playerObjectList, List<IItem> itemObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<INPC> enemyObjectList, List<IUsableItem> usableItemObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<INPC> enemyObjectList, List<IProjectile> projectileObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }



        public void IntersectionDetect(List<INPC> enemyObjectList, List<IBlock> blockObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<IUsableItem> usableItemObjectList, List<IBlock> blockObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<IUsableItem> usableItemObjectList, List<IItem> itemObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<IProjectile> projectileObjectList, List<IBlock> blockObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void IntersectionDetect(List<IProjectile> projectileObjectList, List<IItem> itemObjectList)
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
                                intersectionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                intersectionEventList.Add(intersectionEvent);
                            }
                        }
                    }
                }
            }
        }

        public List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> IntersectionWithSideDetect()
        {
            if (intersectionEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle> wideBandCollisionEvent in intersectionEventList)
                {
                    gameObject1 = wideBandCollisionEvent.Item1;
                    gameObject2 = wideBandCollisionEvent.Item2;
                    intersectionRectangle = wideBandCollisionEvent.Item3;
                    sideOfCollisionObject1 = Enumerations.CollisionSide.None;


                    if(intersectionRectangle.Width >= intersectionRectangle.Height)
                    {
                        if(gameObject1.Center.Y < gameObject2.Center.Y)
                        {
                            sideOfCollisionObject1 = Enumerations.CollisionSide.Bottom;
                        }
                        else
                        {
                            sideOfCollisionObject1 = Enumerations.CollisionSide.Top;
                        }
                    }
                    else
                    {
                        if (gameObject1.Center.X < gameObject2.Center.X)
                        {
                            sideOfCollisionObject1 = Enumerations.CollisionSide.Right;
                        }
                        else
                        {
                            sideOfCollisionObject1 = Enumerations.CollisionSide.Left;
                        }
                    }
                     intersectionWithSideEvent = new Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>(gameObject1, gameObject2, intersectionRectangle, sideOfCollisionObject1);
                     intersectionWithSideEventList.Add(intersectionWithSideEvent);
                }

            }
            return intersectionWithSideEventList;
        }

    }
}
