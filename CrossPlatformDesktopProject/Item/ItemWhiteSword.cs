﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ItemWhiteSword : AbstractItem
    {
        public ItemWhiteSword()
        {
            Sprite = ItemsSpriteFactory.Instance.CreateSpriteWhiteSword();
            Position = Constant.ItemStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.ItemEquipment;
            set => _ = Enumerations.GameObjectType.ItemEquipment;
        }
    }
}
