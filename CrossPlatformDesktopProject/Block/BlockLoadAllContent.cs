using Microsoft.Xna.Framework;
using Sprint2.Block;

namespace Sprint2
{
    public class BlockLoadAllContent
    {
        GameObjects objects;

        public BlockLoadAllContent(Game1 game)
        {
            objects = new GameObjects(game);
        }

        public void LoadContent()
        {
            objects.ListOfBlocks.Add(new BlockDownShutDoor());
            objects.ListOfBlocks.Add(new BlockDownWall());
            objects.ListOfBlocks.Add(new BlockGap());
            objects.ListOfBlocks.Add(new BlockLadder());
            objects.ListOfBlocks.Add(new BlockLeftBombedOpening());
            objects.ListOfBlocks.Add(new BlockLeftLockedDoor());
            objects.ListOfBlocks.Add(new BlockLeftOpenDoor());
            objects.ListOfBlocks.Add(new BlockLeftShutDoor());
            objects.ListOfBlocks.Add(new BlockLeftStatue());
            objects.ListOfBlocks.Add(new BlockLeftWall());
            objects.ListOfBlocks.Add(new BlockRightBombedOpening());
            objects.ListOfBlocks.Add(new BlockRightLockedDoor());
            objects.ListOfBlocks.Add(new BlockRightOpenDoor());
            objects.ListOfBlocks.Add(new BlockRightShutDoor());
            objects.ListOfBlocks.Add(new BlockRightStatue());
            objects.ListOfBlocks.Add(new BlockRightWall());
            objects.ListOfBlocks.Add(new BlockSquare());
            objects.ListOfBlocks.Add(new BlockStairs());
            objects.ListOfBlocks.Add(new BlockUpBombedOpening());
            objects.ListOfBlocks.Add(new BlockUpLockedDoor());
            objects.ListOfBlocks.Add(new BlockUpOpenDoor());
            objects.ListOfBlocks.Add(new BlockUpShutDoor());
            objects.ListOfBlocks.Add(new BlockUpWall());

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
