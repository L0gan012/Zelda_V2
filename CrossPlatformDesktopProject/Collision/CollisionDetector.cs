using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Xna.Framework;


namespace Sprint2.Collision
{
    class CollisionDetector
    {



        List<IPlayer> playerObjectList;
        List<INPC> enemyObjectList;
        List<IProjectile> projectileObjectList;
        List<IBlock> blockObjectList;
        List<IItem> itemObjectList;
        IGameObject gameObject1;
        IGameObject gameObject2;
       


        Tuple<IGameObject, IGameObject, Rectangle> wideBandCollisionEvent;
        List<Tuple<IGameObject, IGameObject, Rectangle>> wideBandCollisionEventList;
        Rectangle intersectionRectangle;


        Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> narrowBandCollisionEvent;
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> narrowBandCollisionEventList;
        Enumerations.CollisionSide sideOfCollisionObject1;


        public CollisionDetector(List<IPlayer> players, List<INPC> enemies, List<IProjectile> projectiles, List<IBlock> blocks, List<IItem> items)
        {
            playerObjectList = players;
            enemyObjectList = enemies;
            projectileObjectList = projectiles;
            blockObjectList = blocks;
            itemObjectList = items;
            wideBandCollisionEventList = new List<Tuple<IGameObject, IGameObject, Rectangle>>();
            narrowBandCollisionEventList = new List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>>();


            if (playerObjectList != null && enemyObjectList != null)
            {
                
                WideBandCollisionDetect(playerObjectList, enemyObjectList);
            }

            if (playerObjectList != null && projectileObjectList != null)
            {
                
                WideBandCollisionDetect(playerObjectList, projectileObjectList);
            }

            if (playerObjectList != null && blockObjectList != null)
            {
                WideBandCollisionDetect(playerObjectList, blockObjectList);
            }

            if (playerObjectList != null && itemObjectList != null)
            {
                WideBandCollisionDetect(playerObjectList, itemObjectList);
            }

            if (enemyObjectList != null && projectileObjectList != null)
            {
                WideBandCollisionDetect(enemyObjectList, projectileObjectList);
            }

            if (enemyObjectList != null && blockObjectList != null)
            {
                WideBandCollisionDetect(enemyObjectList, blockObjectList);
            }

            if (projectileObjectList != null && blockObjectList != null)
            {
                WideBandCollisionDetect(projectileObjectList, blockObjectList);
            }

            if (projectileObjectList != null && itemObjectList != null)
            {
                WideBandCollisionDetect(projectileObjectList, itemObjectList);
            }





            if (wideBandCollisionEventList != null)
            {
                NarrowBandCollisionDetect();
            }


            if(narrowBandCollisionEventList != null)
            {
                CollisionHandler collisionHandler = new CollisionHandler(narrowBandCollisionEventList);
            }


        }


        //TODO: I might be able to implicitly cast these and avoid overloading altogether.  


        public void WideBandCollisionDetect(List<IPlayer> playerObjectList, List<INPC> enemyObjectList)
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
                                gameObject1 = (IGameObject)playerObject;
                                gameObject2 = (IGameObject)enemyObject;
                                wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                wideBandCollisionEventList.Add(wideBandCollisionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void WideBandCollisionDetect(List<IPlayer> playerObjectList, List<IProjectile> projectileObjectList)
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
                                gameObject1 = (IGameObject)playerObject;
                                gameObject2 = (IGameObject)projectileObject;
                                wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                wideBandCollisionEventList.Add(wideBandCollisionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void WideBandCollisionDetect(List<IPlayer> playerObjectList, List<IBlock> blockObjectList)
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
                                gameObject1 = (IGameObject)playerObject;
                                gameObject2 = (IGameObject)blockObject;
                                wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                wideBandCollisionEventList.Add(wideBandCollisionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void WideBandCollisionDetect(List<IPlayer> playerObjectList, List<IItem> itemObjectList)
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
                                wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                wideBandCollisionEventList.Add(wideBandCollisionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void WideBandCollisionDetect(List<INPC> enemyObjectList, List<IProjectile> projectileObjectList)
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
                                wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                wideBandCollisionEventList.Add(wideBandCollisionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void WideBandCollisionDetect(List<INPC> enemyObjectList, List<IBlock> blockObjectList)
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
                                wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                wideBandCollisionEventList.Add(wideBandCollisionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void WideBandCollisionDetect(List<IProjectile> projectileObjectList, List<IBlock> blockObjectList)
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
                                wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                wideBandCollisionEventList.Add(wideBandCollisionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void WideBandCollisionDetect(List<IProjectile> projectileObjectList, List<IItem> itemObjectList)
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
                                wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                                wideBandCollisionEventList.Add(wideBandCollisionEvent);
                            }
                        }
                    }
                }
            }
        }

        public void NarrowBandCollisionDetect()
        {
            if (wideBandCollisionEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle> wideBandCollisionEvent in wideBandCollisionEventList)
                {
                    gameObject1 = wideBandCollisionEvent.Item1;
                    gameObject2 = wideBandCollisionEvent.Item2;
                    intersectionRectangle = wideBandCollisionEvent.Item3;
                    sideOfCollisionObject1 = Enumerations.CollisionSide.None;


                    if(intersectionRectangle.Width >= intersectionRectangle.Height)
                    {
                        if(gameObject1.Center.Y > gameObject2.Center.Y)
                        {
                            sideOfCollisionObject1 = Enumerations.CollisionSide.Top;
                        }
                        else
                        {
                            sideOfCollisionObject1 = Enumerations.CollisionSide.Bottom;
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

                     narrowBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle , Enumerations.CollisionSide>(gameObject1, gameObject2, intersectionRectangle, sideOfCollisionObject1);
                            narrowBandCollisionEventList.Add(narrowBandCollisionEvent);
                        
                    
                }
            }
        }




    }
}
