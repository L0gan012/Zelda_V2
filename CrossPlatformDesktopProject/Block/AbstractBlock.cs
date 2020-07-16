using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class AbstractBlock : AbstractGameObject, IBlock
    {
        //location of this should possibly change
        public override Enumerations.GameObjectType GameObjectType { get; set; } =  Enumerations.GameObjectType.Block;
        
        public override Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y, Sprite.GetWidth(), (int)(Sprite.GetHeight() * .5));
            }
        }

        public bool IsMovable { get; set; }
    }
}
