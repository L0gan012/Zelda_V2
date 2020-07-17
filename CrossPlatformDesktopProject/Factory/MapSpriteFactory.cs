using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class MapSpriteFactory
    {
		private Dictionary<string, Texture2D> mapSpriteContent;
		private static MapSpriteFactory instance = new MapSpriteFactory();

		public static MapSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private MapSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			mapSpriteContent = ImportContent.LoadListContent<Texture2D>(content, "TextureSheets/HUDTextures");
		}

		public ISprite CreateRoomDoorDown()
		{
			return new SpriteMapRoomDoorDown(mapSpriteContent["RoomDoorDown"]);
		}

		public ISprite CreateRoomDoorDownLeft()
		{
			return new SpriteMapRoomDoorDownLeft(mapSpriteContent["RoomDoorDownLeft"]);
		}

		public ISprite CreateRoomDoorDownRight()
		{
			return new SpriteMapRoomDoorDownRight(mapSpriteContent["RoomDoorDownRight"]);
		}

		public ISprite CreateRoomDoorLeft()
		{
			return new SpriteMapRoomDoorLeft(mapSpriteContent["RoomDoorLeft"]);
		}

		public ISprite CreateRoomDoorRight()
		{
			return new SpriteMapRoomDoorRight(mapSpriteContent["RoomDoorRight"]);
		}

		public ISprite CreateRoomDoorsAll()
		{
			return new SpriteMapRoomDoorsAll(mapSpriteContent["RoomDoorsAll"]);
		}

		public ISprite CreateRoomDoorsAllButDown()
		{
			return new SpriteMapRoomDoorsAllButDown(mapSpriteContent["RoomDoorsAllButDown"]);
		}

		public ISprite CreateRoomDoorsAllButLeft()
		{
			return new SpriteMapRoomDoorsAllButLeft(mapSpriteContent["RoomDoorsAllButLeft"]);
		}

		public ISprite CreateRoomDoorsAllButRight()
		{
			return new SpriteMapRoomDoorsAllButRight(mapSpriteContent["RoomDoorsAllButRight"]);
		}

		public ISprite CreateRoomDoorsAllButUp()
		{
			return new SpriteMapRoomDoorsAllButUp(mapSpriteContent["RoomDoorsAllButUp"]);
		}

		public ISprite CreateRoomDoorsHorizontal()
		{
			return new SpriteMapRoomDoorsHorizontal(mapSpriteContent["RoomDoorsHorizontal"]);
		}

		public ISprite CreateRoomDoorsUpLeft()
		{
			return new SpriteMapRoomDoorsUpLeft(mapSpriteContent["RoomDoorsUpLeft"]);
		}

		public ISprite CreateRoomDoorsVertical()
		{
			return new SpriteMapRoomDoorsVertical(mapSpriteContent["RoomDoorsVertical"]);
		}

		public ISprite CreateRoomDoorUp()
		{
			return new SpriteMapRoomDoorUp(mapSpriteContent["RoomDoorUp"]);
		}

		public ISprite CreateRoomDoorUpRight()
		{
			return new SpriteMapRoomDoorsUpRight(mapSpriteContent["RoomDoorUpRight"]);
		}

		public ISprite CreateRoomNoDoors()
		{
			return new SpriteMapRoomNoDoors(mapSpriteContent["RoomNoDoors"]);
		}
	}
}
