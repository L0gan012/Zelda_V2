using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2.Room
{
    public class UpdateRoomObjects
    {

        public UpdateRoomObjects()
        {

        }

        public void UpdateBlock(List<IBlock> currentRoomBlocks)
        {
            if (currentRoomBlocks != null)
            {
                foreach (IBlock block in currentRoomBlocks)
                {
                    block.Update();
                }
            }
        }


        public void UpdatePlayer(List<IPlayer> currentRoomPlayers)
        {
            if (currentRoomPlayers != null)
            {
                foreach (IPlayer player in currentRoomPlayers)
                {
                    player.Update();
                }
            }
        }


        public void UpdateChar(List<INPC> currentRoomChars)
        {
            if (currentRoomChars != null)
            {
                Queue<INPC> deadChars = new Queue<INPC>();

                foreach (INPC character in currentRoomChars)
                {
                    character.Update();
                    if (character.IsDestructable)
                    {
                        deadChars.Enqueue(character);
                    }
                }

                while (deadChars.Count > 0)
                {
                    INPC character = deadChars.Dequeue();
                    currentRoomChars.Remove(character);
                }
            }

        }


        public void UpdateItem(List<IItem> currentRoomItems)
        {
            if (currentRoomItems != null)
            {
                Queue<IItem> removableItems = new Queue<IItem>();

                foreach (IItem item in currentRoomItems)
                {
                    item.Update();
                    if (item.IsDestructable)
                    {
                        removableItems.Enqueue(item);
                    }
                }

                while (removableItems.Count > 0)
                {
                    IItem item = removableItems.Dequeue();
                    currentRoomItems.Remove(item);
                }
            }
        }

        public void UpdateProjecticles(List<IProjectile> currentRoomProjectiles)
        {
            if (currentRoomProjectiles != null)
            {
                Queue<IProjectile> deadProjectiles = new Queue<IProjectile>();

                foreach (IProjectile projectile in currentRoomProjectiles)
                {
                    projectile.Update();
                    if (projectile.IsDestructable)
                    {
                        deadProjectiles.Enqueue(projectile);
                    }
                }

                while (deadProjectiles.Count > 0)
                {
                    IProjectile projectile = deadProjectiles.Dequeue();
                    currentRoomProjectiles.Remove(projectile);
                }
            }
        }


        public void UpdateUseableItems(List<IUsableItem> currentRoomUsableItems)
        {
            if (currentRoomUsableItems != null)
            {
                Queue<IUsableItem> deadUsableItems = new Queue<IUsableItem>();
                foreach (IUsableItem usableItem in currentRoomUsableItems)
                {
                    usableItem.Update();
                    if (usableItem.IsDestructable)
                    {
                        deadUsableItems.Enqueue(usableItem);
                    }
                }

                while (deadUsableItems.Count > 0)
                {
                    IUsableItem usableItem = deadUsableItems.Dequeue();
                    currentRoomUsableItems.Remove(usableItem);
                }
            }
        }

    }
}
