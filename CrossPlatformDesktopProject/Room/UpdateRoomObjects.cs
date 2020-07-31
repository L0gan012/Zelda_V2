using System.Collections.Generic;

namespace Sprint2
{
    public class UpdateRoomObjects
    {

        public UpdateRoomObjects()
        {

        }

        public void UpdateBlock(List<IBlock> currentRoomBlocks)
        {
            if (currentRoomBlocks.Count != 0)
            {
                for (int blockCount = 0; blockCount < currentRoomBlocks.Count; blockCount++)
                {
                    currentRoomBlocks[blockCount].Update();
                    if (currentRoomBlocks[blockCount].IsDestructable)
                    {
                        currentRoomBlocks.Remove(currentRoomBlocks[blockCount]);
                    }
                }
            }
        }

        public void UpdatePlayer(List<IPlayer> currentRoomPlayers)
        {
            foreach (IPlayer player in currentRoomPlayers)
            {
                player.Update();
            }
        }

        public void UpdateChar(List<INPC> currentRoomChars)
        {
            if (currentRoomChars.Count != 0)
            {
                for (int characterCount = 0; characterCount < currentRoomChars.Count; characterCount++)
                {
                    currentRoomChars[characterCount].Update();
                    if (currentRoomChars[characterCount].IsDestructable)
                    {
                        currentRoomChars.Remove(currentRoomChars[characterCount]);
                    }
                }
            }
            else
            {
                ToolsXML toolsXML = new ToolsXML();
                toolsXML.OpenAllSealedDoors(Room.CurrentRoomBlocks);
            }

        }


        public void UpdateItem(List<IItem> currentRoomItems)
        {
            if (currentRoomItems.Count != 0)
            {
                for (int itemCount = 0; itemCount < currentRoomItems.Count; itemCount++)
                {
                    currentRoomItems[itemCount].Update();
                    if (currentRoomItems[itemCount].IsDestructable)
                    {
                        currentRoomItems.Remove(currentRoomItems[itemCount]);
                    }
                }
            }
        }

        public void UpdateProjecticles(List<IProjectile> currentRoomProjectiles)
        {
            if (currentRoomProjectiles.Count != 0)
            {
                for (int projectileCount = 0; projectileCount < currentRoomProjectiles.Count; projectileCount++)
                {
                    currentRoomProjectiles[projectileCount].Update();
                    if (currentRoomProjectiles[projectileCount].IsDestructable)
                    {
                        currentRoomProjectiles.Remove(currentRoomProjectiles[projectileCount]);
                    }
                }
            }
        }

        public void UpdateUseableItems(List<IUsableItem> currentRoomUsableItems)
        {
            if (currentRoomUsableItems.Count != 0)
            {
                for (int usableItemCount = 0; usableItemCount < currentRoomUsableItems.Count; usableItemCount++)
                {
                    currentRoomUsableItems[usableItemCount].Update();
                    if (currentRoomUsableItems[usableItemCount].IsDestructable)
                    {
                        currentRoomUsableItems.Remove(currentRoomUsableItems[usableItemCount]);
                    }
                }
            }
        }

        public void UpdateDoorTriggers(List<IDoorTrigger> currentRoomDoorTriggers)
        {
            if (currentRoomDoorTriggers.Count != 0)
            {

                for (int doorTriggerCount = 0; doorTriggerCount < currentRoomDoorTriggers.Count; doorTriggerCount++)
                {
                    currentRoomDoorTriggers[doorTriggerCount].Update();
                    if (currentRoomDoorTriggers[doorTriggerCount].IsDestructable)
                    {
                        currentRoomDoorTriggers.Remove(currentRoomDoorTriggers[doorTriggerCount]);
                    }
                }
            }
        }
        public void UpdateSpriteEffects(List<ISpriteEffect> currentRoomSpriteEffects)
        {
            if (currentRoomSpriteEffects.Count != 0)
            {
                for (int spriteEffectCount = 0; spriteEffectCount < currentRoomSpriteEffects.Count; spriteEffectCount++)
                {
                    currentRoomSpriteEffects[spriteEffectCount].Update();
                    if (currentRoomSpriteEffects[spriteEffectCount].IsDestructable)
                    {
                        currentRoomSpriteEffects.Remove(currentRoomSpriteEffects[spriteEffectCount]);
                    }
                }
            }
        }
    }
}