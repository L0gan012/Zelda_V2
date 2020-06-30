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

        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight() * .6));
            }
        }


        public bool IsMovable { get; set; }
    }
}
