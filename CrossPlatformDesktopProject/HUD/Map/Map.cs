using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class Map : IMap
    {
        private IPlayer user;
        private ISprite userLocation;
        private Vector2 userPosition;
        private ISprite map;
        private Vector2 mapPosition;

        public Vector2 PlayerGridLocation { get; set; }
        public List<IRoom> DiscoveredRooms { get; }

        public Map(IPlayer user)
        {
            this.user = user;
            userLocation = HUDSpriteFactory.Instance.CreateHUDLinkLocation();
            map = HUDSpriteFactory.Instance.CreateHUDMap();
            mapPosition = Constant.MapPosition;
            userPosition = Constant.UserPosition;

            PlayerGridLocation = new Vector2(Game1.Instance.objects.GetCurrentRoomIndex() / Constant.DungeonGridWidth, Game1.Instance.objects.GetCurrentRoomIndex() % Constant.DungeonGridWidth);
            //DiscoveredRooms.Add(Game1.Instance.objects.currentRoom);
        }

        public void Update()
        {
            map.Update();
            userLocation.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch, Color.White, mapPosition);
            userLocation.Draw(spriteBatch, Color.White, userPosition);
        }
    }
}
