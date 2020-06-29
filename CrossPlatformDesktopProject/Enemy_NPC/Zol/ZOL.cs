﻿using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class Zol : AbstractNPC
    {
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.EnemyGround;
            set => _ = Enumerations.GameObjectType.EnemyGround;
        }

        public Zol()
        {
            Sprite = EnemySpriteFactory.Instance.CreateSpriteEnemyZol();
            Position = Constant.EnemyStartPosition;

            DamageAmount = Constant.ZolDamageAmount;
            MaxHP = Constant.ZolHP;
            CurrentHP = MaxHP;
        }
    }
}
