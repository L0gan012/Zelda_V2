using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint2.Block;
using Sprint2.Sprite;
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
