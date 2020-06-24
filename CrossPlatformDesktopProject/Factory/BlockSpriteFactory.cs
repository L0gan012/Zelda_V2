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

		public IBlock CreateSpriteDownShutDoor()
		{
			return new Blocks(blockSpriteContent["DownShutDoor"], 1, 1);
		}

		public IBlock CreateSpriteDownWall()
		{
			return new Blocks(blockSpriteContent["DownWall"], 1, 1);
		}

		public IBlock CreateSpriteGap()
		{
			return new Blocks(blockSpriteContent["Gap"], 1, 1);
		}

		public IBlock CreateSpriteLadder()
		{
			return new Blocks(blockSpriteContent["Ladder"], 1, 1);
		}

		public IBlock CreateSpriteLeftBombedOpening()
		{
			return new Blocks(blockSpriteContent["LeftBombedOpening"], 1, 1);
		}

		public IBlock CreateSpriteLeftLockedDoor()
		{
			return new Blocks(blockSpriteContent["LeftLockedDoor"], 1, 1);
		}

		public IBlock CreateSpriteLeftOpenDoor()
		{
			return new Blocks(blockSpriteContent["LeftOpenDoor"], 1, 1);
		}

		public IBlock CreateSpriteLeftShutDoor()
		{
			return new Blocks(blockSpriteContent["LeftShutDoor"], 1, 1);
		}

		public IBlock CreateSpriteLeftStatue()
		{
			return new Blocks(blockSpriteContent["LeftStatue"], 1, 1);
		}

		public IBlock CreateSpriteLeftWall()
		{
			return new Blocks(blockSpriteContent["LeftWall"], 1, 1);
		}

		public IBlock CreateSpriteRightBombedOpening()
		{
			return new Blocks(blockSpriteContent["RightBombedOpening"], 1, 1);
		}

		public IBlock CreateSpriteRightLockedDoor()
		{
			return new Blocks(blockSpriteContent["RightLockedDoor"], 1, 1);
		}

		public IBlock CreateSpriteRightOpenDoor()
		{
			return new Blocks(blockSpriteContent["RightOpenDoor"], 1, 1);
		}

		public IBlock CreateSpriteRightShutDoor()
		{
			return new Blocks(blockSpriteContent["RightShutDoor"], 1, 1);
		}

		public IBlock CreateSpriteRightStatue()
		{
			return new Blocks(blockSpriteContent["RightStatue"], 1, 1);
		}

		public IBlock CreateSpriteRightWall()
		{
			return new Blocks(blockSpriteContent["RightWall"], 1, 1);
		}

		public IBlock CreateSpriteSquare()
		{
			return new Blocks(blockSpriteContent["Square"], 1, 1);
		}
		
		public IBlock CreateSpriteStairs()
		{
			return new Blocks(blockSpriteContent["Stairs"], 1, 1);
		}

		public IBlock CreateSpriteUpBombedOpening()
		{
			return new Blocks(blockSpriteContent["UpBombedOpening"], 1, 1);
		}			

		public IBlock CreateSpriteUpLockedDoor()
		{
			return new Blocks(blockSpriteContent["UpLockedDoor"], 1, 1);
		}

		public IBlock CreateSpriteUpOpenDoor()
		{
			return new Blocks(blockSpriteContent["UpOpenDoor"], 1, 1);
		}

		public IBlock CreateSpriteUpShutDoor()
		{
			return new Blocks(blockSpriteContent["UpShutDoor"], 1, 1);
		}				

		public IBlock CreateSpriteUpWall()
		{
			return new Blocks(blockSpriteContent["UpWall"], 1, 1);
		}					


	}
}
