using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockRightShutDoor : AbstractBlock
    {
        public BlockRightShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightShutDoor();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
