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
			return new SpriteEffectEnemyDead(spriteEffectSpriteContent["DeathEnemyWhite"]);
		}

		public ISprite CreateSpriteEffectSwordBeamCollisionNE()
		{
			return new SpriteEffectSwordBeamCollisionNE(spriteEffectSpriteContent["CollisionSwordBeamNE"]);
		}

		public ISprite CreateSpriteEffectSwordBeamCollisionNW()
		{
			return new SpriteEffectSwordBeamCollisionNW(spriteEffectSpriteContent["CollisionSwordBeamNW"]);
		}

		public ISprite CreateSpriteEffectSwordBeamCollisionSE()
		{
			return new SpriteEffectSwordBeamCollisionSE(spriteEffectSpriteContent["CollisionSwordBeamSE"]);
		}

		public ISprite CreateSpriteEffectSwordBeamCollisionSW()
		{
			return new SpriteEffectSwordBeamCollisionSW(spriteEffectSpriteContent["CollisionSwordBeamSW"]);
		}





	}
}
