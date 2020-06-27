using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockUpLockedDoor : AbstractBlock
    {
        public BlockUpLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpLockedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
