﻿using Microsoft.Xna.Framework;

namespace Sprint2
{
    public interface IBlock : IGameObject
    {
        bool IsMovable { get; set; }

        Vector2 Velocity { get; set; }
    }
}
