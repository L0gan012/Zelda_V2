using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
	public class BackgroundSpriteFactory
	{
		private Dictionary<string, Texture2D> backgroundSpriteContent;
		private static BackgroundSpriteFactory instance = new BackgroundSpriteFactory();

		public static BackgroundSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private BackgroundSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			backgroundSpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/RoomTextures");
		}
		
		public ISprite CreateSpriteBackgroundOne()
		{
			return new SpriteBackgroundOne(backgroundSpriteContent["Background1"]);
		}

		public ISprite CreateSpriteBackgroundTwo()
		{
			return new SpriteBackgroundOne(backgroundSpriteContent["Background2"]);
		}
	}
}
