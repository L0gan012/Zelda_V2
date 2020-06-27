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
            return new SpriteBackgroundTwo(backgroundSpriteContent["Background2"]);
        }

		public ISprite CreateSpriteBackgroundThree()
		{
			return new SpriteBackgroundThree(backgroundSpriteContent["Background3"]);
		}

		public ISprite CreateSpriteBackgroundFour()
		{
			return new SpriteBackgroundFour(backgroundSpriteContent["Background4"]);
		}

		public ISprite CreateSpriteBackgroundFive()
		{
			return new SpriteBackgroundFive(backgroundSpriteContent["Background5"]);
		}

		public ISprite CreateSpriteBackgroundSix()
		{
			return new SpriteBackgroundSix(backgroundSpriteContent["Background6"]);
		}

		public ISprite CreateSpriteBackgroundSeven()
		{
			return new SpriteBackgroundSeven(backgroundSpriteContent["Background7"]);
		}

		public ISprite CreateSpriteBackgroundEight()
		{
			return new SpriteBackgroundEight(backgroundSpriteContent["Background8"]);
		}

		public ISprite CreateSpriteBackgroundNine()
		{
			return new SpriteBackgroundNine(backgroundSpriteContent["Background9"]);
		}
		public ISprite CreateSpriteBackgroundTen()
		{
			return new SpriteBackgroundTen(backgroundSpriteContent["Background10"]);
		}

		public ISprite CreateSpriteBackgroundEleven()
		{
			return new SpriteBackgroundEleven(backgroundSpriteContent["Background11"]);
		}

		public ISprite CreateSpriteBackgroundTwelve()
		{
			return new SpriteBackgroundTwelve(backgroundSpriteContent["Background12"]);
		}

		public ISprite CreateSpriteBackgroundThirteen()
		{
			return new SpriteBackgroundThirteen(backgroundSpriteContent["Background13"]);
		}

		public ISprite CreateSpriteBackgroundFourteen()
		{
			return new SpriteBackgroundFourteen(backgroundSpriteContent["Background14"]);
		}

		public ISprite CreateSpriteBackgroundFifteen()
		{
			return new SpriteBackgroundFifteen(backgroundSpriteContent["Background15"]);
		}

		public ISprite CreateSpriteBackgroundSixteen()
		{
			return new SpriteBackgroundSixteen(backgroundSpriteContent["Background16"]);
		}
		public ISprite CreateSpriteBackgroundSeventeen()
		{
			return new SpriteBackgroundSeventeen(backgroundSpriteContent["Background17"]);
		}
	}
}
