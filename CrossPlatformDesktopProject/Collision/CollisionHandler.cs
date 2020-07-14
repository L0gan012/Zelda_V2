using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace Sprint2
{
    public class CollisionHandler
    {
        IGameObject gameObject1;
        IGameObject gameObject2;
        Rectangle intersectionRectangle;
        Enumerations.CollisionSide collisionSideObject1;
       
        List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionSideEventList;
        List<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>> collisionTypeKeyList;

        public CollisionHandler(List<Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide>> collisionSideEventList)
        {
            this.collisionSideEventList = collisionSideEventList;
            collisionTypeKeyList = new List<Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>>();
        }

        public void Update()
        {
            GenerateCollisionEventKey();
            HandleAllEvents();
        }


        public void GenerateCollisionEventKey()
        {
            if (collisionSideEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> collisionSideEvent in collisionSideEventList)
                {
                    gameObject1 = collisionSideEvent.Item1;
                    gameObject2 = collisionSideEvent.Item2;
                    intersectionRectangle = collisionSideEvent.Item3;
                    collisionSideObject1 = collisionSideEvent.Item4;
                    Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide> collisionTypeKey
                        = new Tuple<Enumerations.GameObjectType, Enumerations.GameObjectType, Enumerations.CollisionSide>
                        (gameObject1.GameObjectType, gameObject2.GameObjectType, collisionSideObject1);
                    collisionTypeKeyList.Add(collisionTypeKey);
                }
            }
        }


        public void HandleAllEvents()
        {
            if (collisionSideEventList != null)
            {
                foreach (Tuple<IGameObject, IGameObject, Rectangle, Enumerations.CollisionSide> collisionSideEvent in collisionSideEventList)
                {
                    gameObject1 = collisionSideEvent.Item1;
                    gameObject2 = collisionSideEvent.Item2;
                    intersectionRectangle = collisionSideEvent.Item3;
                    collisionSideObject1 = collisionSideEvent.Item4;



                    #region LinkVsEnemy

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.EnemyGround)
                    {
                        LinkEnemyCollisionHandler.HandleCollision((ILink)gameObject1, (INPC)gameObject2, collisionSideObject1);
                    }

                    
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.EnemyFlying)
                    {
                        LinkEnemyCollisionHandler.HandleCollision((ILink)gameObject1, (INPC)gameObject2, collisionSideObject1);
                    }

                    
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus)
                    {
                        LinkEnemyAquamentusCollisionHandler.HandleCollision((ILink)gameObject1, (INPC)gameObject2, collisionSideObject1);
                    }
                    #endregion LinkVsEnemy



                    #region LinkVsProjectilesAndWeapons

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
                        LinkUsableItemCollisionHandler.HandleCollision((ILink)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        LinkUsableItemCollisionHandler.HandleCollision((ILink)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }

                    #endregion LinkVsProjectilesAndWeapons


                    #region LinkVsItemsAndEquipment

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemInstant)
                    {
                        LinkItemCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemEquipment)
                    {
                        LinkItemEquipmentCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemEquipmentBow)
                    {
                        LinkItemBowCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemKey)
                    {
                        LinkItemKeyCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemTriforcePiece)
                    {
                        LinkItemTriforcePieceCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
                    }


                    #endregion LinkVsItemsAndEquipment



                    #region LinkVsBlocksAndWalls


                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.WallBreakable)
                    {
                        //CorrectHorizontal();
                        //CorrectVertical();
                        //CollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }


                    #endregion LinkVsBlocksAndWalls


                    #region EnemyGround

                    //SectionIncludes
                    //Gel
                    //Stalfos
                    //Goriya
                    

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll)
                    {
                        //NPCProjectileCollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);

                    }



                    //SectionIncludes
                    //Aquamentus


                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy)
                    {
                        NPCAquamentusUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll)
                    {
                        //NPCProjectileCollisionHandler.HandleCollision(gameObject1, gameObject2, sideOfCollisionObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy)
                    {
                        NPCAquamentusUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        NPCAquamentusUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);

                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);

                    }

                    #endregion EnemyGround


                    #region EnemyFlying

                    //SectionIncludes
                    //Keese

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll)
                    {
                        //NPCProjectileCollisionHandler.HandleCollision(gameObject1, gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        //NPCBlockCollisionHandler.HandleCollision(gameObject1, gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {

                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);

                    }



                    #endregion EnemyFlying








                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsPlayer && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        //BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemInstant)
                    {
                        //CollisionHandler.HandleCollision(gameObject1, gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        //BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.WallBreakable)
                    {
                        //BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsPlayer && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        //BlockProjectileCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemInstant)
                    {
                        //CollisionHandler.HandleCollision(gameObject1, gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.Block)
                    {
                        //BlockProjectileCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        BlockProjectileCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        BlockProjectileCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.WallBreakable)
                    {
                        BlockProjectileCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                }
            }
        }

        public void CorrectHorizontal()
        {
            if (collisionSideObject1.Equals(Enumerations.CollisionSide.Left))
            {
                gameObject1.Position = new Vector2(gameObject1.Position.X + intersectionRectangle.Width, gameObject1.Position.Y);
            }

            if (collisionSideObject1.Equals(Enumerations.CollisionSide.Right))
            {
                gameObject1.Position = new Vector2(gameObject1.Position.X - intersectionRectangle.Width, gameObject1.Position.Y);
            }
        }

        public void CorrectVertical()
        {

            if (collisionSideObject1.Equals(Enumerations.CollisionSide.Top))
            {
                gameObject1.Position = new Vector2(gameObject1.Position.X, gameObject1.Position.Y + intersectionRectangle.Height);
            }

            if (collisionSideObject1.Equals(Enumerations.CollisionSide.Bottom))
            {
                gameObject1.Position = new Vector2(gameObject1.Position.X, gameObject1.Position.Y - intersectionRectangle.Height);
            }
        }

    }
}
