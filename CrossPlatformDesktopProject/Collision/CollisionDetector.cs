using System.Collections.Generic;

namespace Sprint2
{
    class CollisionDetector
    {
        ICollisionEvent collisionEvent;
        List<ICollisionEvent> collisionEvents;

        public CollisionDetector(List<IGameObject> gameObjectList1, List<IGameObject> gameObjectList2)
        {
            if (gameObjectList1 != null && gameObjectList2 != null)
            {
                foreach (IGameObject gameObject1 in gameObjectList1)
                {
                    foreach (IGameObject gameObject2 in gameObjectList2)
                    {
                        if (gameObject1.Rectangle.Intersects(gameObject2.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(gameObject1, gameObject2);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }

            }
        }

        public CollisionDetector(List<IPlayer> playerObjectList, List<INPC> enemyObjectList)
        {
            if (playerObjectList != null && enemyObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (INPC enemyObject in enemyObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(enemyObject.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(playerObject, enemyObject);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }
            }
        }

        public CollisionDetector(List<IPlayer> playerObjectList, List<IProjectile> projectileObjectList)
        {
            if (playerObjectList != null && projectileObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (IProjectile projectileObject in projectileObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(projectileObject.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(playerObject, projectileObject);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }
            }
        }

        public CollisionDetector(List<IPlayer> playerObjectList, List<IBlock> blockObjectList)
        {
            if (playerObjectList != null && blockObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (IBlock blockObject in blockObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(blockObject.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(playerObject, blockObject);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }
            }
        }

        public CollisionDetector(List<IPlayer> playerObjectList, List<IItem> itemObjectList)
        {
            if (playerObjectList != null && itemObjectList != null)
            {
                foreach (IPlayer playerObject in playerObjectList)
                {
                    foreach (IItem itemObject in itemObjectList)
                    {
                        if (playerObject.Rectangle.Intersects(itemObject.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(playerObject, itemObject);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }
            }
        }

        public CollisionDetector(List<INPC> enemyObjectList, List<IProjectile> projectileObjectList)
        {
            if (enemyObjectList != null && projectileObjectList != null)
            {
                foreach (INPC enemyObject in enemyObjectList)
                {
                    foreach (IProjectile projectileObject in projectileObjectList)
                    {
                        if (enemyObject.Rectangle.Intersects(projectileObject.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(enemyObject, projectileObject);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }
            }
        }

        public CollisionDetector(List<INPC> enemyObjectList, List<IBlock> blockObjectList)
        {
            if (enemyObjectList != null && blockObjectList != null)
            {
                foreach (INPC enemyObject in enemyObjectList)
                {
                    foreach (IBlock blockObject in blockObjectList)
                    {
                        if (enemyObject.Rectangle.Intersects(blockObject.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(enemyObject, blockObject);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }
            }
        }

        public CollisionDetector(List<IProjectile> projectileObjectList, List<IBlock> blockObjectList)
        {
            if (projectileObjectList != null && blockObjectList != null)
            {
                foreach (IProjectile projectileObject in projectileObjectList)
                {
                    foreach (IBlock blockObject in blockObjectList)
                    {
                        if (projectileObject.Rectangle.Intersects(blockObject.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(projectileObject, blockObject);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }
            }
        }

        public CollisionDetector(List<IProjectile> projectileObjectList, List<IItem> itemObjectList)
        {
            if (projectileObjectList != null && itemObjectList != null)
            {
                foreach (IProjectile projectileObject in projectileObjectList)
                {
                    foreach (IItem itemObject in itemObjectList)
                    {
                        if (projectileObject.Rectangle.Intersects(itemObject.Rectangle))
                        {
                            collisionEvent = new CollisionEvent(projectileObject, itemObject);
                            collisionEvents.Add(collisionEvent);
                        }
                    }
                }
            }
        }



    }
}
