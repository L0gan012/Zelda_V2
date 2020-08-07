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
            HandleAllEvents();
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
                        LinkProjectileCollisionHandler.HandleCollision((ILink)gameObject1, (IProjectile)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsAll)
                    {
                        LinkProjectileCollisionHandler.HandleCollision((ILink)gameObject1, (IProjectile)gameObject2, collisionSideObject1);
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
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemBomb)
                    {
                        LinkItemBombCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemHeart)
                    {
                        LinkItemHeartCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemRupee)
                    {
                        LinkItemRupeeCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemFiveRupee)
                    {
                        LinkItemFiveRupeeCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
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
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.ItemHeartContainer)
                    {
                        LinkItemHeartContainerCollisionHandler.HandleCollision((ILink)gameObject1, (IItem)gameObject2, collisionSideObject1);
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
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.UpBreakableWall)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DownBreakableWall)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftBreakableWall)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.RightBreakableWall)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }








                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.UpLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockUpLockStopCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DownLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockDownLockStopCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockLeftLockStopCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.RightLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockRightLockStopCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.UpSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DownSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.RightSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        LinkBlockCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }






                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorTriggerUp)
                    {
                        LinkDoorTriggerUpCollisionHandler.HandleCollision((ILink)gameObject1, (IDoorTrigger)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorTriggerDown)
                    {
                        LinkDoorTriggerDownCollisionHandler.HandleCollision((ILink)gameObject1, (IDoorTrigger)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorTriggerLeft)
                    {
                        LinkDoorTriggerLeftCollisionHandler.HandleCollision((ILink)gameObject1, (IDoorTrigger)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorTriggerRight)
                    {
                        LinkDoorTriggerRightCollisionHandler.HandleCollision((ILink)gameObject1, (IDoorTrigger)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.StairsTrigger)
                    {
                        LinkBlockStairsTriggerCollisionHandler.HandleCollision((ILink)gameObject1, (IDoorTrigger)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorTriggerExitTreasureRoom)
                    {
                        LinkDoorTriggerLeaveTreasureRoomCollisionHandler.HandleCollision((ILink)gameObject1, (IDoorTrigger)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.UpGuideLeft)
                    {
                        LinkBlockUpGuideLeftCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.UpGuideRight)
                    {
                        LinkBlockUpGuideRightCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DownGuideLeft)
                    {
                        LinkBlockDownGuideLeftCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.DownGuideRight)
                    {
                        LinkBlockDownGuideRightCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftGuideUp)
                    {
                        LinkBlockLeftGuideUpCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftGuideDown)
                    {
                        LinkBlockLeftGuideDownCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.RightGuideUp)
                    {
                        LinkBlockRightGuideUpCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.Player && gameObject2.GameObjectType == Enumerations.GameObjectType.RightGuideDown)
                    {
                        LinkBlockRightGuideDownCollisionHandler.HandleCollision((ILink)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }





                    #endregion LinkVsBlocksAndWalls


                    #region EnemyGround

                    //SectionIncludes
                    //Gel
                    //Stalfos
                    //Goriya

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.ProjectileVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam)
                    {
                        NPCUsableItemSwordBeamCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemBomb)
                    {
                        NPCUsableItemBombCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
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


                    ///Start here
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorDown)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UpLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.RightLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.DownLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UpSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.RightSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.DownSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UpGuideRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.UpGuideLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.DownGuideRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.DownGuideLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftGuideUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftGuideDown)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.RightGuideUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyGround && gameObject2.GameObjectType == Enumerations.GameObjectType.RightGuideDown)
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
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy)
                    {
                        NPCAquamentusUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        NPCAquamentusUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam)
                    {
                        NPCUsableItemSwordBeamCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemBomb)
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




                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorDown)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UpLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.RightLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.DownLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UpSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.RightSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.DownSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UpGuideRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.UpGuideLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.DownGuideRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.DownGuideLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftGuideUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftGuideDown)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.RightGuideUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyAquamentus && gameObject2.GameObjectType == Enumerations.GameObjectType.RightGuideDown)
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
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsEnemy)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam)
                    {
                        NPCUsableItemSwordBeamCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UsableItemBomb)
                    {
                        NPCUsableItemCollisionHandler.HandleCollision((INPC)gameObject1, (IUsableItem)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }

                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorDown)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UpLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.RightLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.DownLockStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UpSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.RightSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.DownSealStop)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UpGuideRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.UpGuideLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.DownGuideRight)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.DownGuideLeft)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftGuideUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftGuideDown)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.RightGuideUp)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.EnemyFlying && gameObject2.GameObjectType == Enumerations.GameObjectType.RightGuideDown)
                    {
                        CorrectHorizontal();
                        CorrectVertical();
                        NPCBlockCollisionHandler.HandleCollision((INPC)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }


                    #endregion EnemyFlying







                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemVsAll && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        BlockUsableItemCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.Wall)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorUp)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorDown)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorLeft)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.DoorRight)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.UpBreakableWall)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.DownBreakableWall)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftBreakableWall)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemSwordBeam && gameObject2.GameObjectType == Enumerations.GameObjectType.RightBreakableWall)
                    {
                        UsableItemSwordBeamWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }




                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemBomb && gameObject2.GameObjectType == Enumerations.GameObjectType.UpBreakableWall)
                    {
                        UsableItemBombUpBreakableWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemBomb && gameObject2.GameObjectType == Enumerations.GameObjectType.DownBreakableWall)
                    {
                        UsableItemBombDownBreakableWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemBomb && gameObject2.GameObjectType == Enumerations.GameObjectType.LeftBreakableWall)
                    {
                        UsableItemBombLeftBreakableWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
                    }
                    if (gameObject1.GameObjectType == Enumerations.GameObjectType.UsableItemBomb && gameObject2.GameObjectType == Enumerations.GameObjectType.RightBreakableWall)
                    {
                        UsableItemBombRightBreakableWallCollisionHandler.HandleCollision((IUsableItem)gameObject1, (IBlock)gameObject2, collisionSideObject1);
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
