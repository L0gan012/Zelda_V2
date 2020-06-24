using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockUpOpenDoor : AbstractBlock
    {
        public BlockUpOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpOpenDoor();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
