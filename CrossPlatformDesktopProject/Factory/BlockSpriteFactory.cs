using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint2.Sprite;
using Sprint2;

namespace Sprint2.Factory
{
	public class BlockSpriteFactory
	{

		//Dictionary populated with TextureContent class
		private Dictionary<string, Texture2D> blockSpriteContent;


		/*
		// All spritesheet instance listed here
		private Texture2D statueSpritesheet;
		private Texture2D squareSpritesheet;
		private Texture2D wallSpritesheet;
		private Texture2D lockedDoorSpritesheet;
		private Texture2D openDoorSpritesheet;
		private Texture2D shutDoorSpritesheet;
		private Texture2D stairsSpritesheet;
		private Texture2D ladderTileSpritesheet;
		private Texture2D brickTileSpritesheet;
		private Texture2D bombedOpeningSpritesheet;
		private Texture2D gapTileSpritesheet;
		*/

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

		//Load all textures
		public void LoadAllTextures(ContentManager content)
		{

			//Loads the Dictionary with all the item textures in ItemTextures folder
			blockSpriteContent = TextureContent.LoadListContent<Texture2D>(content, "TextureSheets/BlockTextures");


			/*
			statueSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Statue");
			squareSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Square");
			wallSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Wall");
			lockedDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/LockedDoor");
			openDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/OpenDoor");
			shutDoorSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/ShutDoor");
			stairsSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Stairs");
			ladderTileSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Ladder");
			brickTileSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Brick");
			bombedOpeningSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/BombedOpening");
			gapTileSpritesheet = content.Load<Texture2D>("TextureSheets/BlockTextures/Gap");
			*/
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
