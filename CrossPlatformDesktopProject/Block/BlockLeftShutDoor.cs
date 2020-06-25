using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockLeftShutDoor : AbstractBlock
    {
        public BlockLeftShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftShutDoor();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
