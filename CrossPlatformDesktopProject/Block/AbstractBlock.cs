using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class AbstractBlock : AbstractGameObject, IBlock
    {
        //location of this should possibly change
        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public virtual bool IsMovable { get; set; }

        public virtual Vector2 Velocity { get; set; }
    }
}
