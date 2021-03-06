﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BlockUpOverWall : AbstractGameObject, IDoorTrigger
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.DoorTriggerUp;

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, (int)Sprite.GetWidth(), (int)(Sprite.GetHeight()));
            }
        }

        public BlockUpOverWall()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteUpOverWall();
            Position = Constant.BlockStartPosition;
        }
    }
}