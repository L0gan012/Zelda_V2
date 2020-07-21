﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Map : IMap
    {
        private int row;
        private int column;

        private ISprite userIndicator;
        private Vector2 userPosition;
        private ISprite map;
        private Vector2 mapPosition;

        public Vector2 PlayerGridLocation { get; set; }

        public Map()
        {
            userIndicator = HUDSpriteFactory.Instance.CreateHUDLinkLocation();
            map = HUDSpriteFactory.Instance.CreateHUDMap();
            mapPosition = Constant.MapPosition;
            userPosition = Constant.UserMapPosition;
            PlayerGridLocation = new Vector2(GameObjects.Instance.LevelListPosition / Constant.DungeonGridWidth, GameObjects.Instance.LevelListPosition % Constant.DungeonGridWidth);
        }

        public void Update()
        {
            PlayerGridLocation = new Vector2(GameObjects.Instance.LevelListPosition / Constant.DungeonGridWidth, GameObjects.Instance.LevelListPosition % Constant.DungeonGridWidth);
            map.Update();
            userIndicator.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch, Color.White, mapPosition);
            DrawDiscoveredRooms(spriteBatch);
            userIndicator.Draw(spriteBatch, Color.White, userPosition + new Vector2(PlayerGridLocation.Y * Constant.MapRoomWidth, PlayerGridLocation.X * Constant.MapRoomHeight));
        }

        private void DrawDiscoveredRooms(SpriteBatch spriteBatch)
        {
            foreach(KeyValuePair<int, IRoom> pair in MiniHUD.DiscoveredRooms)
            {
                ISprite roomSprite = MapSpriteFactory.Instance.CreateRoomNoDoors();
                List<Enumerations.Direction> list = pair.Value.doorDirections; 

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
                else if(list.Count == 4)
                {
                    roomSprite = MapSpriteFactory.Instance.CreateRoomDoorsAll();
                }

                if (list.Count > 0)
                {
                    row = pair.Key / Constant.DungeonGridWidth;
                    column = pair.Key % Constant.DungeonGridWidth;

                    roomSprite.Draw(spriteBatch, Color.White, Constant.MapRoomPosition + new Vector2(column * Constant.MapRoomWidth, row * Constant.MapRoomHeight));
                }
            }
        }
    }
}
