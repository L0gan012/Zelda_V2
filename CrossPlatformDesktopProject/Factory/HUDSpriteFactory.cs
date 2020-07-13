using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class HUDSpriteFactory
    {
		private Dictionary<string, Texture2D> hudSpriteContent;
		private static HUDSpriteFactory instance = new HUDSpriteFactory();

		public static HUDSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private HUDSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			hudSpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/HUDTextures");
		}

		public ISprite CreateHUDASlot()
		{
			return new SpriteHUDASlot(hudSpriteContent["ASlot"]);
		}

		public ISprite CreateHUDBomb()
		{
			return new SpriteHUDBomb(hudSpriteContent["Bomb"]);
		}

		public ISprite CreateHUDBSlot()
		{
			return new SpriteHUDBSlot(hudSpriteContent["BSlot"]);
		}

		public ISprite CreateHUDFullHeart()
		{
			return new SpriteHUDFullHeart(hudSpriteContent["FullHeart"]);
		}

		public ISprite CreateHUDHalfHeart()
		{
			return new SpriteHUDHalfHeart(hudSpriteContent["HalfHeart"]);
		}

		public ISprite CreateHUDInventoryBox()
		{
			return new SpriteHUDInventoryBox(hudSpriteContent["InventoryBox"]);
		}

		public ISprite CreateHUDItemSelector()
		{
			return new SpriteHUDItemSelector(hudSpriteContent["ItemSelector"]);
		}

		public ISprite CreateHUDKey()
		{
			return new SpriteHUDKey(hudSpriteContent["Key"]);
		}

		public ISprite CreateHUDLinkLocation()
		{
			return new SpriteHUDLinkLocation(hudSpriteContent["LinkLocation"]);
		}

		public ISprite CreateHUDMap()
		{
			return new SpriteHUDBigMap(hudSpriteContent["Map"]);
		}

		public ISprite CreateHUDMiniMapRoom()
		{
			return new SpriteHUDMiniMapRoom(hudSpriteContent["MiniMapRoom"]);
		}

		public ISprite CreateHUDNoHeart()
		{
			return new SpriteHUDNoHeart(hudSpriteContent["NoHeart"]);
		}

		public ISprite CreateHUDRupee()
		{
			return new SpriteHUDRupee(hudSpriteContent["Rupee"]);
		}

		public ISprite CreateHUDSecondaryItemBox()
		{
			return new SpriteHUDSecondaryItemBox(hudSpriteContent["SecondaryItemBox"]);
		}

		public ISprite CreateHUDtriforcePieceLocation()
		{
			return new SpriteHUDTriforcePieceLocation(hudSpriteContent["TriforcePieceLocation"]);
		}
	}
}
