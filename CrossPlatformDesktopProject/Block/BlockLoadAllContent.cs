using Microsoft.Xna.Framework;

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
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteDownShutDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteDownWall());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteGap());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLadder());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftBombedOpening());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftLockedDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftOpenDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftShutDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftStatue());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteLeftWall());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightBombedOpening());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightLockedDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightOpenDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightShutDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightStatue());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteRightWall());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteSquare());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteStairs());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpBombedOpening());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpLockedDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpOpenDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpShutDoor());
            objects.ListOfBlocks.Add(BlockSpriteFactory.Instance.CreateSpriteUpWall());
        }
    }
}
