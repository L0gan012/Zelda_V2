using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockUpShutDoor : AbstractBlock
    {
        public BlockUpShutDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpShutDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
