using Microsoft.Xna.Framework;
using System;


namespace Sprint2.Block
{
    class BlockRightOpenDoor : AbstractBlock
    {
        public BlockRightOpenDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightOpenDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
