using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
	public class EnemySpriteFactory
	{
		private Dictionary<string, Texture2D> enemySpriteContent;
		private static EnemySpriteFactory instance = new EnemySpriteFactory();

		public static EnemySpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private EnemySpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			enemySpriteContent = ImportContent.LoadListContent<Texture2D>(content, "TextureSheets/EnemyTextures");
		}

		public ISprite CreateSpriteEnemyAquamentus()
		{
			return new SpriteEnemyAquamentus(enemySpriteContent["EnemyAquamentus"]);
		}

		public ISprite CreateSpriteEnemyAquamentusMouthOpen()
		{
			return new SpriteEnemyAquamentusMouthOpen(enemySpriteContent["EnemyAquamentusMouthOpen"]);
		}

		public ISprite CreateSpriteEnemyDodongoDown()
		{
			return new SpriteEnemyDodongoDown(enemySpriteContent["EnemyDodongoDown"]);
		}

		public ISprite CreateSpriteEnemyDodongoDownPuffed()
		{
			return new SpriteEnemyDodongoDownPuffed(enemySpriteContent["EnemyDodongoDownPuffed"]);
		}

		public ISprite CreateSpriteEnemyDodongoLeft()
		{
			return new SpriteEnemyDodongoLeft(enemySpriteContent["EnemyDodongoLeft"]);
		}

		public ISprite CreateSpriteEnemyDodongoLeftPuffed()
		{
			return new SpriteEnemyDodongoLeftPuffed(enemySpriteContent["EnemyDodongoLeftPuffed"]);
		}

		public ISprite CreateSpriteEnemyDodongoRight()
		{
			return new SpriteEnemyDodongoRight(enemySpriteContent["EnemyDodongoRight"]);
		}

		public ISprite CreateSpriteEnemyDodongoRightPuffed()
		{
			return new SpriteEnemyDodongoRightPuffed(enemySpriteContent["EnemyDodongoRightPuffed"]);
		}

		public ISprite CreateSpriteEnemyDodongoUp()
		{
			return new SpriteEnemyDodongoUp(enemySpriteContent["EnemyDodongoUp"]);
		}

		public ISprite CreateSpriteEnemyDodongoUpPuffed()
		{
			return new SpriteEnemyDodongoUpPuffed(enemySpriteContent["EnemyDodongoUpPuffed"]);
		}

		public ISprite CreateSpriteEnemyGel()
		{
			return new SpriteEnemyGel(enemySpriteContent["EnemyGel"]);
		}

		public ISprite CreateSpriteEnemyGoriyaWalkDown()
		{
			return new SpriteEnemyGoriyaWalkDown(enemySpriteContent["EnemyGoriyaWalkDown"]);
		}

		public ISprite CreateSpriteEnemyGoriyaWalkLeft()
		{
			return new SpriteEnemyGoriyaWalkLeft(enemySpriteContent["EnemyGoriyaWalkLeft"]);
		}

		public ISprite CreateSpriteEnemyGoriyaWalkRight()
		{
			return new SpriteEnemyGoriyaWalkRight(enemySpriteContent["EnemyGoriyaWalkRight"]);
		}

		public ISprite CreateSpriteEnemyGoriyaWalkUp()
		{
			return new SpriteEnemyGoriyaWalkUp(enemySpriteContent["EnemyGoriyaWalkUp"]);
		}

		public ISprite CreateSpriteEnemyKeese()
		{
			return new SpriteEnemyKeese(enemySpriteContent["EnemyKeese"]);
		}

		public ISprite CreateSpriteEnemyRopeLeft()
		{
			return new SpriteEnemyRopeLeft(enemySpriteContent["EnemyRopeLeft"]);
		}

		public ISprite CreateSpriteEnemyRopeRight()
		{
			return new SpriteEnemyRopeRight(enemySpriteContent["EnemyRopeRight"]);
		}

		public ISprite CreateSpriteEnemySpikeCross()
		{
			return new SpriteEnemySpikeCross(enemySpriteContent["EnemySpikeCross"]);
		}

		public ISprite CreateSpriteEnemyStalfos()
		{
			return new SpriteEnemyStalfos(enemySpriteContent["EnemyStalfos"]);
		}

		public ISprite CreateSpriteEnemyWallmasterLeft()
		{
			return new SpriteEnemyWallmasterLeft(enemySpriteContent["EnemyWallmasterLeft"]);
		}

		public ISprite CreateSpriteEnemyWallmasterRight()
		{
			return new SpriteEnemyWallmasterRight(enemySpriteContent["EnemyWallmasterRight"]);
		}

		public ISprite CreateSpriteEnemyZol()
		{
			return new SpriteEnemyZol(enemySpriteContent["EnemyZol"]);
		}
	}
}
