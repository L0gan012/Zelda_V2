using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Sprite;
using System.Collections.Generic;

namespace Sprint2
{
	public class ProjectileSpriteFactory
	{
		private Dictionary<string, Texture2D> projectileSpriteContent;
		private static ProjectileSpriteFactory instance = new ProjectileSpriteFactory();

		public static ProjectileSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private ProjectileSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			projectileSpriteContent = ImportContent.LoadListContent<Texture2D>(content, "TextureSheets/ProjectileTextures");
		}

		public ISprite CreateSpriteProjectileBombExplosion()
		{
			return new SpriteProjectileAquamentus(projectileSpriteContent["ProjectileBombExplosion"]);
		}

		public ISprite CreateSpriteProjectileAquamentus()
		{
			return new SpriteProjectileAquamentus(projectileSpriteContent["ProjectileAquamentus"]);
		}

		public ISprite CreateSpriteProjectileCandle()
		{
			return new SpriteProjectileCandle(projectileSpriteContent["ProjectileCandle"]);
		}

		public ISprite CreateSpriteProjectileFlame()
        {
			return new SpriteProjectileFlame(projectileSpriteContent["ProjectileFlame"]);
        }

		public ISprite CreateSpriteProjectileMagicBoomerang()
		{
			return new SpriteProjectileMagicBoomerang(projectileSpriteContent["ProjectileMagicBoomerang"]);
		}

		public ISprite CreateSpriteProjectileSilverArrowDown()
		{
			return new SpriteProjectileSilverArrowDown(projectileSpriteContent["ProjectileSilverArrowDown"]);
		}

		public ISprite CreateSpriteProjectileSilverArrowLeft()
		{
			return new SpriteProjectileSilverArrowLeft(projectileSpriteContent["ProjectileSilverArrowLeft"]);
		}

		public ISprite CreateSpriteProjectileSilverArrowRight()
		{
			return new SpriteProjectileSilverArrowRight(projectileSpriteContent["ProjectileSilverArrowRight"]);
		}

		public ISprite CreateSpriteProjectileSilverArrowUp()
		{
			return new SpriteProjectileSilverArrowUp(projectileSpriteContent["ProjectileSilverArrowUp"]);
		}

		public ISprite CreateSpriteProjectileWoodenArrowDown()
		{
			return new SpriteProjectileWoodenArrowDown(projectileSpriteContent["ProjectileWoodenArrowDown"]);
		}

		public ISprite CreateSpriteProjectileWoodenArrowLeft()
		{
			return new SpriteProjectileWoodenArrowLeft(projectileSpriteContent["ProjectileWoodenArrowLeft"]);
		}

		public ISprite CreateSpriteProjectileWoodenArrowRight()
		{
			return new SpriteProjectileWoodenArrowRight(projectileSpriteContent["ProjectileWoodenArrowRight"]);
		}

		public ISprite CreateSpriteProjectileWoodenArrowUp()
		{
			return new SpriteProjectileWoodenArrowUp(projectileSpriteContent["ProjectileWoodenArrowUp"]);
		}

		public ISprite CreateSpriteProjectileWoodenBoomerang()
		{
			return new SpriteProjectileWoodenBoomerang(projectileSpriteContent["ProjectileWoodenBoomerang"]);
		}

		public ISprite CreateSpriteProjectileWoodenSwordUp()
		{
			return new SpriteProjectileWoodenSwordUp(projectileSpriteContent["ProjectileSwordUp"]);
		}

		public ISprite CreateSpriteProjectileWoodenSwordDown()
		{
			return new SpriteProjectileWoodenSwordDown(projectileSpriteContent["ProjectileSwordDown"]);
		}

		public ISprite CreateSpriteProjectileWoodenSwordRight()
		{
			return new SpriteProjectileWoodenSwordRight(projectileSpriteContent["ProjectileSwordRight"]);
		}

		public ISprite CreateSpriteProjectileWoodenSwordLeft()
		{
			return new SpriteProjectileWoodenSwordLeft(projectileSpriteContent["ProjectileSwordLeft"]);
		}

		public ISprite CreateSpriteWoodenSwordUp()
		{
			return new SpriteItemWoodSwordUp(projectileSpriteContent["ProjectileWoodenSwordUp"]);
		}

		public ISprite CreateSpriteWoodenSwordDown()
		{
			return new SpriteItemWoodSwordDown(projectileSpriteContent["ProjectileWoodenSwordDown"]);
		}

		public ISprite CreateSpriteWoodenSwordRight()
		{
			return new SpriteItemWoodSwordRight(projectileSpriteContent["ProjectileWoodenSwordRight"]);
		}

		public ISprite CreateSpriteWoodenSwordLeft()
		{
			return new SpriteItemWoodSwordLeft(projectileSpriteContent["ProjectileWoodenSwordLeft"]);
		}

		public ISprite CreateSpriteDebugBlankTexture()
		{
			return new SpriteDebugBlankTexture(projectileSpriteContent["DebugBlank"]);
		}
	}
}
