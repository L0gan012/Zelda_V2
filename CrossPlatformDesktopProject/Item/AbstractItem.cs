using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public abstract class AbstractItem : AbstractGameObject, IItem
    {
        //location of this should possibly change
        public override Enumerations.GameObjectType GameObjectType
        {
            get => Enumerations.GameObjectType.ItemInstant;
            set => _ = Enumerations.GameObjectType.ItemInstant;
        }

        public virtual void PickUp(IGameObject user)

        {
            //must make abstract later, every item should implement its own version
            IsDestructable = true;
        }
    }
}
