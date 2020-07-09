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
            foreach (IBlock block in currentRoomBlocks)
            {
                block.Update();
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
    }
}
