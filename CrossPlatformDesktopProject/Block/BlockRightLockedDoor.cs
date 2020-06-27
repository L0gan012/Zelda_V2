using Microsoft.Xna.Framework;
using System;


namespace Sprint2.Block
{
    class BlockRightLockedDoor : AbstractBlock
    {
        public BlockRightLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightLockedDoor();
            Position = Constant.BlockStartPosition;
        }
    }
}
