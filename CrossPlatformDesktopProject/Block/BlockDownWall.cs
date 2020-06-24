using Microsoft.Xna.Framework;
using System;

namespace Sprint2.Block
{
    class BlockDownWall : AbstractBlock
    {
        public BlockDownWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteDownWall();
            Position = Constant.BlockStartPosition;
            Color = Color.White;
        }

    }
}
