using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Sprint2.Interfaces;


namespace Sprint2.Collision
{
    class WideBandCollisionDetector
    {

        Tuple<IGameObject, IGameObject, Rectangle> wideBandCollisionEvent;
        List<Tuple<IGameObject, IGameObject, Rectangle>> wideBandCollisionEventList;
        Rectangle intersectionRectangle;

        public WideBandCollisionDetector()
        {
            
        }




        public WideBandCollisionDetector(List<IGameObject> gameObjectList1, List<IGameObject> gameObjectList2)
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
                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(gameObject1, gameObject2, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }


        
        
        public WideBandCollisionDetector(List<IPlayer> playerObjectList, List<INPC> enemyObjectList)
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
                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(playerObject, enemyObject, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }

        public WideBandCollisionDetector(List<IPlayer> playerObjectList, List<IProjectile> projectileObjectList)
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
                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(playerObject, projectileObject, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }

        public WideBandCollisionDetector(List<IPlayer> playerObjectList, List<IBlock> blockObjectList)
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
                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(playerObject, blockObject, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }

        public WideBandCollisionDetector(List<IPlayer> playerObjectList, List<IItem> itemObjectList)
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
                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(playerObject, itemObject, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }

        public WideBandCollisionDetector(List<INPC> enemyObjectList, List<IProjectile> projectileObjectList)
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
                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(enemyObject, projectileObject, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }

        public WideBandCollisionDetector(List<INPC> enemyObjectList, List<IBlock> blockObjectList)
        {
            if (enemyObjectList != null && blockObjectList != null)
            {
                foreach (INPC enemyObject in enemyObjectList)
                {
                    foreach (IBlock blockObject in blockObjectList)
                    {
                        if (enemyObject.Rectangle.Intersects(blockObject.Rectangle))
                        {
                            intersectionRectangle = Rectangle.Intersect(enemyObject.Rectangle, blockObject.Rectangle);
                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(enemyObject, blockObject, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }

        public WideBandCollisionDetector(List<IProjectile> projectileObjectList, List<IBlock> blockObjectList)
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
                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(projectileObject, blockObject, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }

        public WideBandCollisionDetector(List<IProjectile> projectileObjectList, List<IItem> itemObjectList)
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

                            wideBandCollisionEvent = new Tuple<IGameObject, IGameObject, Rectangle>(projectileObject, itemObject, intersectionRectangle);
                            wideBandCollisionEventList.Add(wideBandCollisionEvent);
                        }
                    }
                }
            }
        }



    }
}
