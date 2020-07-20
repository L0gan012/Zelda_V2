using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
	public class ItemsSpriteFactory
    {
		private Dictionary<string, Texture2D> itemSpriteContent;
		private static ItemsSpriteFactory instance = new ItemsSpriteFactory();

		public static ItemsSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private ItemsSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			itemSpriteContent = ImportContent.LoadListContent<Texture2D>(content, "TextureSheets/ItemTextures");
		}
		 
		public ISprite CreateSpriteBlueCandle()
		{
			return new SpriteItemBlueCandle(itemSpriteContent["ItemBlueCandle"]);
		}

		public ISprite CreateSpriteBluePotion()
		{
			return new SpriteItemBluePotion(itemSpriteContent["ItemBluePotion"]);
		}

		public ISprite CreateSpriteBlueRing()
        {
			return new SpriteItemBlueRing(itemSpriteContent["ItemBlueRing"]);
        }

		public ISprite CreateSpriteBomb()
		{
			return new SpriteItemBomb(itemSpriteContent["ItemBomb"]);
		}

		public ISprite CreateSpriteBow()
		{
			return new SpriteItemBow(itemSpriteContent["ItemBow"]);
		}

		public ISprite CreateSpriteClock()
		{
			return new SpriteItemClock(itemSpriteContent["ItemClock"]);
		}

		public ISprite CreateSpriteCompass()
		{
			return new SpriteItemCompass(itemSpriteContent["ItemCompass"]);
		}

		public ISprite CreateSpriteFairy()
		{
			return new SpriteItemFairy(itemSpriteContent["ItemFairy"]);
		}

		public ISprite CreateSpriteFlute()
		{
			return new SpriteItemFlute(itemSpriteContent["ItemFlute"]);
		}

		public ISprite CreateSpriteHeartContainer()
		{
			return new SpriteItemHeartContainer(itemSpriteContent["ItemHeartContainer"]);
		}

		public ISprite CreateSpriteHeart()
		{
			return new SpriteItemHeart(itemSpriteContent["ItemHeart"]);
		}

		public ISprite CreateSpriteKey()
		{
			return new SpriteItemKey(itemSpriteContent["ItemKey"]);
		}

		public ISprite CreateSpriteLadder()
		{
			return new SpriteItemLadder(itemSpriteContent["ItemLadder"]);
		}

		public ISprite CreateSpriteMagicBoomerang()
		{
			return new SpriteItemMagicBoomerang(itemSpriteContent["ItemMagicBoomerang"]);
		}

		public ISprite CreateSpriteMagicRod()
		{
			return new SpriteItemMagicRod(itemSpriteContent["ItemMagicRod"]);
		}

		public ISprite CreateSpriteMagicShield()
		{
			return new SpriteItemMagicShield(itemSpriteContent["ItemMagicShield"]);
		}

		public ISprite CreateSpriteMap()
		{
			return new SpriteItemMap(itemSpriteContent["ItemMap"]);
		}

		public ISprite CreateSpritePotionNote()
		{
			return new SpriteItemPotionNote(itemSpriteContent["ItemPotionNote"]);
		}

		public ISprite CreateSpritePowerBracelet()
		{
			return new SpriteItemPowerBracelet(itemSpriteContent["ItemPowerBracelet"]);
		}

		public ISprite CreateSpriteRaft()
		{
			return new SpriteItemRaft(itemSpriteContent["ItemRaft"]);
		}

		public ISprite CreateSpriteRedPotion()
		{
			return new SpriteItemRedPotion(itemSpriteContent["ItemRedPotion"]);
		}

		public ISprite CreateSpriteRupee()
		{
			return new SpriteItemRupee(itemSpriteContent["ItemRupee"]);
		}

		public ISprite CreateSpriteSilverArrow()
		{
			return new SpriteItemSilverArrow(itemSpriteContent["ItemSilverArrow"]);
		}

		public ISprite CreateSpriteItemTriforcePiece()
		{
			return new SpriteItemTriforcePiece(itemSpriteContent["ItemTriforcePiece"]);
		}

		public ISprite CreateSpriteWhiteSword()
		{
			return new SpriteItemWhiteSword(itemSpriteContent["ItemWhiteSword"]);
		}

		public ISprite CreateSpriteWoodenSword()
		{
			return new SpriteItemWhiteSword(itemSpriteContent["ItemWoodenSword"]);
		}

		public ISprite CreateSpriteWoodenArrow()
		{
			return new SpriteItemWoodenArrow(itemSpriteContent["ItemWoodenArrow"]);
		}


		public ISprite CreateItemFire()
		{
			return new SpriteItemFire(itemSpriteContent["ItemFire"]);
		}
		public ISprite CreateSpriteItemWoodenBoomerang()
		{
			return new SpriteItemWoodenBoomerang(itemSpriteContent["ItemWoodenBoomerang"]);
		}
	}
}
