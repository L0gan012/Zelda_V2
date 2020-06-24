using Microsoft.Xna.Framework;
using System;

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
