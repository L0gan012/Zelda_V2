using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockLeftLockedDoor : AbstractBlock
    {
        public BlockLeftLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
