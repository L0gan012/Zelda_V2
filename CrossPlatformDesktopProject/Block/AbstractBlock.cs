using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class AbstractBlock : AbstractGameObject, IBlock
    {
        //location of this should possibly change
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.Block;
            set => _ = Enumerations.GameObjectType.Block;
        }

        public bool IsMovable { get; set; }
    }
}
