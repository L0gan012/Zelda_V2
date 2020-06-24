using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockRightBombedOpening : AbstractBlock
    {
        public BlockRightBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightBombedOpening();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
