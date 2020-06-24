using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockUpBombedOpening : AbstractBlock
    {
        public BlockUpBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpBombedOpening();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
