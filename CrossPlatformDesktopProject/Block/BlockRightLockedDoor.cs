﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockRightLockedDoor : AbstractBlock
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorRight;

        public BlockRightLockedDoor()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteRightLockedDoor();
            Position = Constant.BlockStartPosition;
        }
        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }
    }
}
