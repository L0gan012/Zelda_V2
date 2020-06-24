using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockLeftBombedOpening : AbstractBlock
    {
        public BlockLeftBombedOpening()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLeftBombedOpening();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }
    }
}
