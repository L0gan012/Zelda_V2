﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        public List<IRoom> DiscoveredRooms { get; }

        public MiniMap(IPlayer user)
        {
            this.user = user;

            userIndicator = HUDSpriteFactory.Instance.CreateHUDLinkLocation();
            triforcePiece = HUDSpriteFactory.Instance.CreateHUDtriforcePieceLocation();
            miniMap = CreateMiniMap();
            userPosition = Constant.UserMiniMapPosition;
            triforcePiecePosition = Constant.TriforcePiecePosition;
            miniMapPosition = Constant.MiniMapPosition;
        }

        public void Update()
        {
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
                        if (!miniMap[i, j].Equals(null))
                        {
                            miniMap[i, j].Draw(spriteBatch, Color.White, Constant.MiniMapPosition + new Vector2(j * Constant.MiniMapRoomWidth, i * Constant.MiniMapRoomHeight));
                        }
                    }
                }
            }
            if (user.Inventory.HasCompass)
            {
                triforcePiece.Draw(spriteBatch, Color.White, triforcePiecePosition);
            }
            userIndicator.Draw(spriteBatch, Color.White, userPosition);
        }

        private ISprite[,] CreateMiniMap()
        {
            ISprite[,] map = new ISprite[Constant.DungeonGridWidth, Constant.DungeonGridHeight];

            for (int i = 0; i < Constant.DungeonGridHeight; i++)
            {
                for (int j = 0; j < Constant.DungeonGridWidth; j++)
                {
                    map[i, j] = HUDSpriteFactory.Instance.CreateHUDMiniMapRoom();
                }
            }
            return map;
        }
    }
}
