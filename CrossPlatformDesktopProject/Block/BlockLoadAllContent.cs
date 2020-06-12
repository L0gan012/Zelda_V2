using Sprint2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class BlockLoadAllContent
    {

        //Instance variables
        Game1 game;

        public BlockLoadAllContent(Game1 game)
        {
            this.game = game;
        }

        //Initailizes all game items
        public void LoadContent()
        {
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteDownShutDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteDownWall());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteGap());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLadder());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftBombedOpening());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftLockedDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftOpenDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftShutDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftStatue());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftWall());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightBombedOpening());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightLockedDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightOpenDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightShutDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightStatue());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightWall());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteSquare());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteStairs());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpBombedOpening());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpLockedDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpOpenDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpShutDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpWall());



        /*
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteStatue());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteSquare());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteWall());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLockedDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteOpenDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteShutDoor());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteStairs());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLadderTile());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteBrickTile());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteBombedOpening());
            game.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteGapTile());
        */
        }
    }
}
