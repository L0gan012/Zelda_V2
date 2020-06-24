using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Block;
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
			return new BlockDownShutDoor(blockSpriteContent["DownShutDoor"], 1, 1);
		}

		public ISprite CreateSpriteDownWall()
		{
			return new BlockDownWall(blockSpriteContent["DownWall"], 1, 1);
		}

		public ISprite CreateSpriteGap()
		{
			return new BlockGap(blockSpriteContent["Gap"], 1, 1);
		}

		public ISprite CreateSpriteLadder()
		{
			return new BlockLadder(blockSpriteContent["Ladder"], 1, 1);
		}

		public ISprite CreateSpriteLeftBombedOpening()
		{
			return new BlockLeftBombedOpening(blockSpriteContent["LeftBombedOpening"], 1, 1);
		}

		public ISprite CreateSpriteLeftLockedDoor()
		{
			return new BlockLeftLockedDoor(blockSpriteContent["LeftLockedDoor"], 1, 1);
		}

		public ISprite CreateSpriteLeftOpenDoor()
		{
			return new BlockLeftOpenDoor(blockSpriteContent["LeftOpenDoor"], 1, 1);
		}

		public ISprite CreateSpriteLeftShutDoor()
		{
			return new BlockLeftShutDoor(blockSpriteContent["LeftShutDoor"], 1, 1);
		}

		public ISprite CreateSpriteLeftStatue()
		{
			return new BlockLeftStatue(blockSpriteContent["LeftStatue"], 1, 1);
		}

		public ISprite CreateSpriteLeftWall()
		{
			return new BlockLeftWall(blockSpriteContent["LeftWall"], 1, 1);
		}

		public ISprite CreateSpriteRightBombedOpening()
		{
			return new BlockRightBombedOpening(blockSpriteContent["RightBombedOpening"], 1, 1);
		}

		public ISprite CreateSpriteRightLockedDoor()
		{
			return new BlockRightLockedDoor(blockSpriteContent["RightLockedDoor"], 1, 1);
		}

		public ISprite CreateSpriteRightOpenDoor()
		{
			return new BlockRightOpenDoor(blockSpriteContent["RightOpenDoor"], 1, 1);
		}

		public ISprite CreateSpriteRightShutDoor()
		{
			return new BlockRightShutDoor(blockSpriteContent["RightShutDoor"], 1, 1);
		}

		public ISprite CreateSpriteRightStatue()
		{
			return new BlockRightStatue(blockSpriteContent["RightStatue"], 1, 1);
		}

		public ISprite CreateSpriteRightWall()
		{
			return new BlockRightWall(blockSpriteContent["RightWall"], 1, 1);
		}

		public ISprite CreateSpriteSquare()
		{
			return new BlockSquare(blockSpriteContent["Square"], 1, 1);
		}
		
		public ISprite CreateSpriteStairs()
		{
			return new BlockStairs(blockSpriteContent["Stairs"], 1, 1);
		}

		public ISprite CreateSpriteUpBombedOpening()
		{
			return new BlockBombedOpening(blockSpriteContent["UpBombedOpening"], 1, 1);
		}			

		public ISprite CreateSpriteUpLockedDoor()
		{
			return new BlockUpLockedDoor(blockSpriteContent["UpLockedDoor"], 1, 1);
		}

		public ISprite CreateSpriteUpOpenDoor()
		{
			return new BlockUpOpenDoor(blockSpriteContent["UpOpenDoor"], 1, 1);
		}

		public ISprite CreateSpriteUpShutDoor()
		{
			return new BlockUpShutDoor(blockSpriteContent["UpShutDoor"], 1, 1);
		}				

		public ISprite CreateSpriteUpWall()
		{
			return new BlockUpWall(blockSpriteContent["UpWall"], 1, 1);
		}					



		/*
		public IBlock CreateSpriteStatue()
		{
			return new Blocks(statueSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteSquare()
		{
			return new Blocks(squareSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteWall()
		{
			return new Blocks(wallSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteLockedDoor()
		{
			return new Blocks(lockedDoorSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteOpenDoor()
		{
			return new Blocks(openDoorSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteShutDoor()
		{
			return new Blocks(shutDoorSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteStairs()
		{
			return new Blocks(stairsSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteLadderTile()
		{
			return new Blocks(ladderTileSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteBrickTile()
		{
			return new Blocks(brickTileSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteBombedOpening()
		{
			return new Blocks(bombedOpeningSpritesheet, 1, 1);
		}
		public IBlock CreateSpriteGapTile()
		{
			return new Blocks(gapTileSpritesheet, 1, 1);
		}
		*/
	}
}
