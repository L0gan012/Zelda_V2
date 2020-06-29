using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    class CollisionController
    {


        public CollisionController(IGameObject gameObject1, IGameObject gameObject2, Enumerations.CollisionSide collisionSide, List<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>> collisionKeyList)
        {
     /*       collisionCommandDictionary = new Dictionary<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>, ICollisionHandler>();
            this.gameObject1 = gameObject1;
            this.gameObject2 = gameObject2;
            this.collisionSide = collisionSide;  */
        }

























        /*
         private Dictionary<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>, > collisionCommandDictionary;
        IGameObject gameObject1;
        IGameObject gameObject2;
        Enumerations.CollisionSide collisionSide;

        public CollisionController(IGameObject gameObject1, IGameObject gameObject2, Enumerations.CollisionSide collisionSide, List<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>> collisionKeyList)
        {
            collisionCommandDictionary = new Dictionary<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>, ICollisionHandler>();
            this.gameObject1 = gameObject1;
            this.gameObject2 = gameObject2;
            this.collisionSide = collisionSide;
        }

        public void RegisterCommand()
        {
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Top), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Top);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Left), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Left);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Right), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Right);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
            collisionCommandDictionary.Add(Tuple.Create(Enumerations.GameObjectType.Player, Enumerations.GameObjectType.EnemyGround, Enumerations.CollisionSide.Bottom), LinkEnemyCollisionHandler.HandleCollision(gameObject1, gameObject2, Enumerations.CollisionSide.Bottom);
       
            }

        public void Update()
        {
            Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>(gameObject1.GameObjectType, gameObject2.GameObjectType, collisionSide)

            {
                foreach (Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide> collisionKey in collisionKeyList)
                {
                    if (collisionCommandDictionary.ContainsKey()
                    {
                        collisionCommandDictionary[collisionKey].HandleCollision();
                        prev = key;
                    }
                }
            }
        } */
    } 
}
