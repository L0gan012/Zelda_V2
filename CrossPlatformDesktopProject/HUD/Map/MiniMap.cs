using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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
        private Vector2 playerGridLocation;

        public MiniMap(IPlayer user)
        {
            this.user = user;

            userIndicator = HUDSpriteFactory.Instance.CreateHUDLinkLocation();
            triforcePiece = HUDSpriteFactory.Instance.CreateHUDtriforcePieceLocation();
            CreateMiniMap();
            playerGridLocation = new Vector2(GameObjects.Instance.LevelListPosition / Constant.DungeonGridWidth, GameObjects.Instance.LevelListPosition % Constant.DungeonGridWidth);
        }

        public void Update()
        {
            playerGridLocation = new Vector2(GameObjects.Instance.LevelListPosition / Constant.DungeonGridWidth, GameObjects.Instance.LevelListPosition % Constant.DungeonGridWidth);
            if (user.Inventory.HasCompass)
            {
                triforcePiece.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            miniMapPosition = MiniHUD.MiniHUDPosition + Constant.MiniMapPosition;
            userPosition = miniMapPosition + Constant.UserMiniMapPosition;
            triforcePiecePosition = miniMapPosition + Constant.TriforcePiecePosition;

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
            userIndicator.Draw(spriteBatch, Color.White, userPosition + new Vector2(playerGridLocation.Y * Constant.MiniMapRoomWidth, playerGridLocation.X * Constant.MiniMapRoomHeight));
        }

        private void CreateMiniMap()
        {
            miniMap = new ISprite[Constant.DungeonGridWidth, Constant.DungeonGridHeight];

            for (int i = 0; i < Constant.DungeonGridHeight; i++)
            {
                for (int j = 0; j < Constant.DungeonGridWidth; j++)
                {
                    int roomGridIndex = Constant.DungeonGridWidth * i + j;
                    if (Room.GridNumbers.Contains(roomGridIndex))
                    {
                        miniMap[i, j] = HUDSpriteFactory.Instance.CreateHUDMiniMapRoom();
                    }
                    else
                    {
                        miniMap[i, j] = null;
                    }
                }
            }
        }
    }
}
