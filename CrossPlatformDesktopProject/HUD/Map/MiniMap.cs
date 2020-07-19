using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class MiniMap : IMap
    {
        private IPlayer user;

        private ISprite userIndicator;
        private Vector2 userPosition;
        private ISprite triforcePiece;
        private Vector2 triforcePiecePosition;
        private ISprite[,] miniMap;
        private Vector2 miniMapPosition;

        public Vector2 PlayerGridLocation { get; set; }
        public Dictionary<int, IRoom> DiscoveredRooms { get; }

        public MiniMap(IPlayer user)
        {
            this.user = user;

            userIndicator = HUDSpriteFactory.Instance.CreateHUDLinkLocation();
            triforcePiece = HUDSpriteFactory.Instance.CreateHUDtriforcePieceLocation();
            miniMap = CreateMiniMap();
            userPosition = Constant.UserMiniMapPosition;
            PlayerGridLocation = new Vector2(GameObjects.Instance.LevelListPosition / Constant.DungeonGridWidth, GameObjects.Instance.LevelListPosition % Constant.DungeonGridWidth);
            triforcePiecePosition = Constant.TriforcePiecePosition;
            miniMapPosition = Constant.MiniMapPosition;
        }

        public void Update()
        {
            PlayerGridLocation = new Vector2(GameObjects.Instance.LevelListPosition / Constant.DungeonGridWidth, GameObjects.Instance.LevelListPosition % Constant.DungeonGridWidth);
            if (user.Inventory.HasCompass)
            {
                triforcePiece.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (user.Inventory.HasMap)
            {
                for (int i = 0; i < Constant.DungeonGridHeight; i++)
                {
                    for (int j = 0; j < Constant.DungeonGridWidth; j++)
                    {
                        if (miniMap[i, j] != null)
                        {
                            miniMap[i, j].Draw(spriteBatch, Color.White, miniMapPosition + new Vector2(j * Constant.MiniMapRoomWidth, i * Constant.MiniMapRoomHeight));
                        }
                    }
                }
            }
            if (user.Inventory.HasCompass)
            {
                triforcePiece.Draw(spriteBatch, Color.White, triforcePiecePosition);
            }
            userIndicator.Draw(spriteBatch, Color.White, userPosition + new Vector2(PlayerGridLocation.Y * Constant.MiniMapRoomWidth, PlayerGridLocation.X * Constant.MiniMapRoomHeight));
        }

        private ISprite[,] CreateMiniMap()
        {
            ISprite[,] map = new ISprite[Constant.DungeonGridWidth, Constant.DungeonGridHeight];

            for (int i = 0; i < Constant.DungeonGridHeight; i++)
            {
                for (int j = 0; j < Constant.DungeonGridWidth; j++)
                {
                    int roomGridIndex = Constant.DungeonGridWidth * i + j;
                    if (Room.gridNumbers.Contains(roomGridIndex))
                    {
                        map[i, j] = HUDSpriteFactory.Instance.CreateHUDMiniMapRoom();
                    }
                    else
                    {
                        map[i, j] = null;
                    }
                }
            }
            return map;
        }
    }
}
