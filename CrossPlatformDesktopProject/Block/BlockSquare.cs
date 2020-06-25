using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockSquare : AbstractBlock
    {
        public BlockSquare()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteSquare();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
