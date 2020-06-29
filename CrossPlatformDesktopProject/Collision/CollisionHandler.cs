

using Microsoft.Xna.Framework;
using Sprint2.Collision.NPCHandlers;
using System;
using System.Collections.Generic;


namespace Sprint2.Collision
{
    public class CollisionHandler
    {
        IGameObject gameObject1;
        IGameObject gameObject2;
        Rectangle intersectionRectangle;
        Enumerations.CollisionSide sideOfCollisionObject1;
        //Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide> collisionTypeKey;
        //List<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>> collisionTypeKeyList;
        List<Tuple<IGameObject, IGameObject, Enumerations.CollisionSide>> collisionEventList;
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> narrowBandEventList;


      //Constructor Argument List      List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> narrowBandEventList


        public CollisionHandler()
        {
         //   this.narrowBandEventList = narrowBandEventList;


        }

        public void Update()
        {
            GenerateCollisionEventKey();
            CorrectHorizontal();
            CorrectHorizontal();
        }

        public void GenerateCollisionEventKey()
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


                }
            }
        }

        public void CorrectHorizontal()
        {
            if (narrowBandEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> narrowBandEvent in narrowBandEventList)
                {
                    gameObject1 = narrowBandEvent.Item1;
                    gameObject2 = narrowBandEvent.Item2;
                    intersectionRectangle = narrowBandEvent.Item3;
                    sideOfCollisionObject1 = narrowBandEvent.Item4;

                    if (sideOfCollisionObject1.Equals(Enumerations.CollisionSide.Left))
                    {
                        gameObject1.Position = new Vector2(gameObject1.Position.X + intersectionRectangle.X, gameObject1.Position.Y);
                    }

                    if (sideOfCollisionObject1.Equals(Enumerations.CollisionSide.Left))
                    {
                        gameObject1.Position = new Vector2(gameObject1.Position.X - intersectionRectangle.X, gameObject1.Position.Y);
                    }

                }
            }
        }

        public void CorrectVertical()
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
                        gameObject1.Position = new Vector2(gameObject1.Position.X, gameObject1.Position.Y - intersectionRectangle.Y);
                    }

                    if (sideOfCollisionObject1.Equals(Enumerations.CollisionSide.Bottom))
                    {
                        gameObject1.Position = new Vector2(gameObject1.Position.X, gameObject1.Position.Y + intersectionRectangle.Y);
                    }

                }
            }
        }

        public void HandleAllEvents()
        {
            if (narrowBandEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> narrowBandEvent in narrowBandEventList)
                {
                    gameObject1 = narrowBandEvent.Item1;
                    gameObject2 = narrowBandEvent.Item2;
                    intersectionRectangle = narrowBandEvent.Item3;
                    sideOfCollisionObject1 = narrowBandEvent.Item4;


                    if(gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.EnemyGround)
                    {
                        LinkEnemyCollisionHandler.HandleCollision((ILink)gameObject1, (INPC)gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.EnemyFlying)
                    {
                        LinkEnemyCollisionHandler.HandleCollision((ILink)gameObject1, (INPC)gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsPlayer)
                    {
                        //LinkProjectileCollisionHandler.HandleCollision((ILink)gameObject1, (IProjectile)gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll)
                    {
                        //LinkProjectileCollisionHandler.HandleCollision((ILink)gameObject1, (IProjectile)gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsPlayer)
                    {
                        LinkProjectileCollisionHandler.HandleCollision((ILink)gameObject1, (IUsableItem)gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        LinkProjectileCollisionHandler.HandleCollision((ILink)gameObject1, (IUsableItem)gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemInstant)
                    {
                        LinkItemCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemEquipment)
                    {
                        //CollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        //CollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }


                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.WallBreakable)
                    {
                        //CollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }



                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll)
                    {
                        //NPCProjectileCollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }


                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy)
                    {
                        //NPCProjectileCollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll)
                    {
                        //NPCProjectileCollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy)
                    {
                        //NPCProjectileCollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        //NPCProjectileCollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        //NPCBlockCollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsPlayer && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemInstant)
                    {
                        //CollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.WallBreakable)
                    {
                        BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsPlayer && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        BlockProjectileCollisionHandler.HandleCollision((IProjectile)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemInstant)
                    {
                        //CollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        BlockProjectileCollisionHandler.HandleCollision((IProjectile)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        BlockProjectileCollisionHandler.HandleCollision((IProjectile)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.WallBreakable)
                    {
                        BlockProjectileCollisionHandler.HandleCollision((IProjectile)gameObject1, (IBlock)gameObject2, sideOfCollisionObject1);
                    }


















                }


            }

        }

    }
}
