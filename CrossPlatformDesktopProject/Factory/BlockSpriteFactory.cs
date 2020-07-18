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
			blockSpriteContent = ImportContent.LoadListContent<Texture2D>(content, "TextureSheets/BlockTextures");
		}

		public ISprite CreateSpriteDownShutDoor()
		{
			return new SpriteBlockDownShutDoor(blockSpriteContent["DownShutDoor"]);
		}

		public ISprite CreateSpriteDownOpenDoor()
		{
			return new SpriteBlockDownShutDoor(blockSpriteContent["DownOpenDoor"]);
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

		public ISprite CreateSpriteBrick()
		{
			return new SpriteBlockBrick(blockSpriteContent["Brick"]);
		}



		//New
		public ISprite CreateSpriteBlackTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["BlackTile"]);
		}

		public ISprite CreateSpriteBrickTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["BrickTile"]);
		}

		public ISprite CreateSpriteLadderTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["LadderTile"]);
		}

		public ISprite CreateSpriteLeftStatueTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["LeftStatueBlue"]);
		}

		public ISprite CreateSpriteRightStatueTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["RightStatueBlue"]);
		}

		public ISprite CreateSpriteStairsTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["Stairs"]);
		}

		public ISprite CreateSpriteBlockTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["Square"]);
		}

		public ISprite CreateSpriteWaterTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["WaterTile"]);
		}

		public ISprite CreateSpriteFloorTile()
		{
			return new SpriteBlockBrick(blockSpriteContent["FloorTile"]);
		}

		public ISprite CreateSpriteUpOverDoor()
		{
			return new SpriteBlockBrick(blockSpriteContent["UpOverDoor"]);
		}

		public ISprite CreateSpriteDownOverDoor()
		{
			return new SpriteBlockBrick(blockSpriteContent["DownOverDoor"]);
		}

		public ISprite CreateSpriteLeftOverDoor()
		{
			return new SpriteBlockBrick(blockSpriteContent["LeftOverDoor"]);
		}

		public ISprite CreateSpriteRightOverDoor()
		{
			return new SpriteBlockBrick(blockSpriteContent["RightOverDoor"]);
		}

		public ISprite CreateSpriteUpOverBombed()
		{
			return new SpriteBlockBrick(blockSpriteContent["UpOverBombed"]);
		}

		public ISprite CreateSpriteDownOverBombed()
		{
			return new SpriteBlockBrick(blockSpriteContent["DownOverBombed"]);
		}

		public ISprite CreateSpriteLeftOverBombed()
		{
			return new SpriteBlockBrick(blockSpriteContent["LeftOverBombed"]);
		}

		public ISprite CreateSpriteRightOverBombed()
		{
			return new SpriteBlockBrick(blockSpriteContent["RightOverBombed"]);
		}
		public ISprite CreateSpriteDownLockedDoor()
		{
			return new SpriteBlockBrick(blockSpriteContent["DownLockedDoor"]);
		}

		public ISprite CreateSpriteDownBombedDoor()
		{
			return new SpriteBlockBrick(blockSpriteContent["DownBombedOpening"]);
		}





	}
}
