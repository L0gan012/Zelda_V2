using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Sprite;
using System.Collections.Generic;

namespace Sprint2
{
	public class SpriteEffectSpriteFactory
	{
		private Dictionary<string, Texture2D> spriteEffectSpriteContent;
		public static SpriteEffectSpriteFactory Instance { get; } = new SpriteEffectSpriteFactory();

		private SpriteEffectSpriteFactory()
		{

		}

		public void LoadAllTextures(ContentManager content)
		{
			spriteEffectSpriteContent = ImportContent.LoadListContent<Texture2D>(content, "TextureSheets/SpriteEffectTextures");
		}


		public ISprite CreateSpriteEnemyDeadEffectWhite()
		{
			return new SpriteEffectEnemyDead(spriteEffectSpriteContent["DeadEnemyWhite"]);
		}

	}
}
