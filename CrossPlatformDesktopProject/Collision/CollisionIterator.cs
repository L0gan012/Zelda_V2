using Microsoft.Xna.Framework;
using Sprint2.Interfaces;
using Sprint2.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Collision
{

    /// <summary>
    /// The CollisionIterator takes the currentObjects and sorts them into 
    /// </summary>
    class CollisionIterator
    {
        List<IPlayer> players;
        List<INPC> enemies;
        List<IProjectile> projectiles;
        List<IBlock> blocks;
        List<IItem> items;
        List<ICollisionEvent> collisionEvents;
        ICollisionEvent collisionEvent;
        
        
        CollisionIterator()
        {
            

            if(players != null && enemies != null)
            {
                CollisionDetector playersVsEnemies = new CollisionDetector(players, enemies);
                //collisionEvent = playersVsEnemies.CheckForCollision(players, enemies);
                collisionEvents.Add(collisionEvent);
            }

            if (players != null && projectiles != null)
            {
                CollisionDetector playersVsProjectiles = new CollisionDetector(players, projectiles);
                //collisionEvent = playersVsProjectiles.CheckForCollision(players, projectiles);
                collisionEvents.Add(collisionEvent);
            }

            if (players != null && blocks != null)
            {
                CollisionDetector playersVsBlocks = new CollisionDetector(players, blocks);
                //collisionEvent = playersVsBlocks.CheckForCollision(players, blocks);
                collisionEvents.Add(collisionEvent);
            }

            if (players != null && items != null)
            {
                CollisionDetector playersVsItems = new CollisionDetector(players, items);
                //collisionEvent = playersVsItems.CheckForCollision(players, items);
                collisionEvents.Add(collisionEvent);
            }

            if (enemies != null && projectiles != null)
            {
                CollisionDetector enemiesVsProjectiles = new CollisionDetector(enemies, projectiles);
                //collisionEvent = enemiesVsProjectiles.CheckForCollision(enemies, projectiles);
                collisionEvents.Add(collisionEvent);
            }

            if (enemies != null && blocks != null)
            {
                CollisionDetector enemiesVsBlocks = new CollisionDetector(enemies, blocks);
                //collisionEvent = enemiesVsBlocks.CheckForCollision(enemies, blocks);
                collisionEvents.Add(collisionEvent);
            }

            if (projectiles != null && blocks != null)
            {
                CollisionDetector projectilesVsBlocks = new CollisionDetector(projectiles, blocks);
               // collisionEvent = projectilesVsBlocks.CheckForCollision(projectiles, blocks);
                collisionEvents.Add(collisionEvent);
            }

            if (projectiles != null && items != null)
            {
                CollisionDetector projectilesVsItems = new CollisionDetector(projectiles, items);
               // collisionEvent = projectilesVsItems.CheckForCollision(projectiles, items);
                collisionEvents.Add(collisionEvent);
            }











            
        }

    }
}
