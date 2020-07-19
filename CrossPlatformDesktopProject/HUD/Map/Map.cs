using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class Map : IMap
    {
        private int row;
        private int column;

        private ISprite user;
        private Vector2 userPosition;
        private ISprite map;
        private Vector2 mapPosition;

        public Vector2 PlayerGridLocation { get; set; }
        public List<IRoom> DiscoveredRooms { get; } = new List<IRoom>();

        public Map()
        {
            user = HUDSpriteFactory.Instance.CreateHUDLinkLocation();
            map = HUDSpriteFactory.Instance.CreateHUDMap();
            mapPosition = Constant.MapPosition;
            userPosition = Constant.UserMapPosition;

            row = GameObjects.Instance.LevelListPosition / Constant.DungeonGridWidth;
            column = GameObjects.Instance.LevelListPosition % Constant.DungeonGridWidth;

            PlayerGridLocation = new Vector2(row, column);
        }

        public void Update()
        {
            map.Update();
            user.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch, Color.White, mapPosition);
            DrawDiscoveredRooms(spriteBatch);
            user.Draw(spriteBatch, Color.White, userPosition);
        }

        private void DrawDiscoveredRooms(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            foreach(IRoom room in DiscoveredRooms)
            {
                List<Enumerations.Direction> list = room.doorDirections;
                ISprite roomSprite = MapSpriteFactory.Instance.CreateRoomNoDoors();

                if(list.Count == 1)
                {
                    if (list.Contains(Enumerations.Direction.Left))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorLeft();
                    }
                    else if (list.Contains(Enumerations.Direction.Right))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorRight();
                    }
                    else if (list.Contains(Enumerations.Direction.Up))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorUp();
                    }
                    else 
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorDown();
                    }
                }
                else if(list.Count == 2)
                {
                    if (list.Contains(Enumerations.Direction.Up) && list.Contains(Enumerations.Direction.Left))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsUpLeft();
                    }
                    else if (list.Contains(Enumerations.Direction.Up) && list.Contains(Enumerations.Direction.Right))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorUpRight();
                    }
                    else if (list.Contains(Enumerations.Direction.Up) && list.Contains(Enumerations.Direction.Down))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsVertical();
                    }
                    else if (list.Contains(Enumerations.Direction.Down) && list.Contains(Enumerations.Direction.Left))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorDownLeft();
                    }
                    else if (list.Contains(Enumerations.Direction.Down) && list.Contains(Enumerations.Direction.Right))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorDownRight();
                    }
                    else
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsHorizontal();
                    }
                }
                else if(list.Count == 3)
                {
                    if (!list.Contains(Enumerations.Direction.Left))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsAllButLeft();
                    }
                    else if (!list.Contains(Enumerations.Direction.Right))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsAllButRight();
                    }
                    else if (!list.Contains(Enumerations.Direction.Up))
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsAllButUp();
                    }
                    else
                    {
                        roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsAllButDown();
                    }
                }
                else
                {
                    roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsAll();
                }

                roomSprite.Draw(spriteBatch, Color.White, Constant.MapPosition + new Vector2(column * Constant.MapRoomWidth, row * Constant.MapRoomHeight));
            }
            spriteBatch.End();
        }
    }
}
