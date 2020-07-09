using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IRoom 
    {
        List<IItem> CurrentRoomItems { get; set; }

        List<INPC> CurrentRoomChars { get; set; }

        List<IBlock> CurrentRoomBlocks { get; set; }

        List<IPlayer> CurrentRoomPlayers { get; set; }

        List<IProjectile> CurrentRoomProjectiles { get; set; }

       List<IUsableItem> CurrentRoomUsableItems { get; set; }

        void StoreRoom();
        void LoadRoom();

        void Draw(SpriteBatch spriteBatch);

        void Update();
    }
}
