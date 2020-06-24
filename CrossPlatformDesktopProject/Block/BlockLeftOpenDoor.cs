using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockLeftOpenDoor : AbstractBlock
    {
        public BlockLeftOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftOpenDoor();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
