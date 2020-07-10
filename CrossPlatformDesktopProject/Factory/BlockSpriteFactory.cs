using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
	public class BlockSpriteFactory
	{
		private Dictionary<string, Texture2D> blockSpriteContent;
		private static BlockSpriteFactory instance = new BlockSpriteFactory();

		public static BlockSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private BlockSpriteFactory()
		{
		}

		public void LoadAllTextures(ContentManager content)
		{
			blockSpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/BlockTextures");
		}

		public ISprite CreateSpriteDownShutDoor()
		{
			return new SpriteBlockDownShutDoor(blockSpriteContent["DownShutDoor"]);
		}

		public ISprite CreateSpriteDownWall()
		{
			return new SpriteBlockDownWall(blockSpriteContent["DownWall"]);
		}

		public ISprite CreateSpriteGap()
		{
			return new SpriteBlockGap(blockSpriteContent["Gap"]);
		}

		public ISprite CreateSpriteLadder()
		{
			return new SpriteBlockLadder(blockSpriteContent["Ladder"]);
		}

		public ISprite CreateSpriteLeftBombedOpening()
		{
			return new SpriteBlockLeftBombedOpening(blockSpriteContent["LeftBombedOpening"]);
		}

		public ISprite CreateSpriteLeftLockedDoor()
		{
			return new SpriteBlockLeftLockedDoor(blockSpriteContent["LeftLockedDoor"]);
		}

		public ISprite CreateSpriteLeftOpenDoor()
		{
			return new SpriteBlockLeftOpenDoor(blockSpriteContent["LeftOpenDoor"]);
		}

		public ISprite CreateSpriteLeftShutDoor()
		{
			return new SpriteBlockLeftShutDoor(blockSpriteContent["LeftShutDoor"]);
		}

		public ISprite CreateSpriteLeftStatue()
		{
			return new SpriteBlockLeftStatue(blockSpriteContent["LeftStatue"]);
		}

		public ISprite CreateSpriteLeftWall()
		{
			return new SpriteBlockLeftWall(blockSpriteContent["LeftWall"]);
		}

		public ISprite CreateSpriteRightBombedOpening()
		{
			return new SpriteBlockRightBombedOpening(blockSpriteContent["RightBombedOpening"]);
		}

		public ISprite CreateSpriteRightLockedDoor()
		{
			return new SpriteBlockRightLockedDoor(blockSpriteContent["RightLockedDoor"]);
		}

		public ISprite CreateSpriteRightOpenDoor()
		{
			return new SpriteBlockRightOpenDoor(blockSpriteContent["RightOpenDoor"]);
		}

		public ISprite CreateSpriteRightShutDoor()
		{
			return new SpriteBlockRightShutDoor(blockSpriteContent["RightShutDoor"]);
		}

		public ISprite CreateSpriteRightStatue()
		{
			return new SpriteBlockRightStatue(blockSpriteContent["RightStatue"]);
		}

		public ISprite CreateSpriteRightWall()
		{
			return new SpriteBlockRightWall(blockSpriteContent["RightWall"]);
		}

		public ISprite CreateSpriteSquare()
		{
			return new SpriteBlockSquare(blockSpriteContent["Square"]);
		}
		
		public ISprite CreateSpriteStairs()
		{
			return new SpriteBlockStairs(blockSpriteContent["Stairs"]);
		}

		public ISprite CreateSpriteUpBombedOpening()
		{
			return new SpriteBlockBombedOpening(blockSpriteContent["UpBombedOpening"]);
		}			

		public ISprite CreateSpriteUpLockedDoor()
		{
			return new SpriteBlockUpLockedDoor(blockSpriteContent["UpLockedDoor"]);
		}

		public ISprite CreateSpriteUpOpenDoor()
		{
			return new SpriteBlockUpOpenDoor(blockSpriteContent["UpOpenDoor"]);
		}

		public ISprite CreateSpriteUpShutDoor()
		{
			return new SpriteBlockUpShutDoor(blockSpriteContent["UpShutDoor"]);
		}				

		public ISprite CreateSpriteUpWall()
		{
			return new SpriteBlockUpWall(blockSpriteContent["UpWall"]);
		}

		public ISprite CreateSpriteBottomLeftWall()
		{
			return new SpriteBlockBottomLeftWall(blockSpriteContent["BottomLeftWall"]);
		}

		public ISprite CreateSpriteBottomRightWall()
		{
			return new SpriteBlockBottomRightWall(blockSpriteContent["BottomRightWall"]);
		}

		public ISprite CreateSpriteTopLeftWall()
		{
			return new SpriteBlockTopLeftWall(blockSpriteContent["TopLeftWall"]);
		}

		public ISprite CreateSpriteTopRightWall()
		{
			return new SpriteBlockTopRightWall(blockSpriteContent["TopRightWall"]);
		}

		public ISprite CreateSpriteLeftBottomWall()
		{
			return new SpriteBlockLeftBottomWall(blockSpriteContent["LeftBottomWall"]);
		}

		public ISprite CreateSpriteRightBottomWall()
		{
			return new SpriteBlockRightBottomWall(blockSpriteContent["RightBottomWall"]);
		}

		public ISprite CreateSpriteLeftTopWall()
		{
			return new SpriteBlockLeftTopWall(blockSpriteContent["LeftTopWall"]);
		}

		public ISprite CreateSpriteRightTopWall()
		{
			return new SpriteBlockRightTopWall(blockSpriteContent["RightTopWall"]);
		}


	}
}
