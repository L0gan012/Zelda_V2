using Microsoft.Xna.Framework;

namespace Sprint2.Block
{
    class BlockDownShutDoor : AbstractBlock
    {
        public BlockDownShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownShutDoor();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
