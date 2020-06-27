using System;

namespace Sprint2
{
    public abstract class AbstractItem : AbstractGameObject, IItem
    {
        //location of this should possibly change
        public override Enumerations.GameObjectType GameObjectType
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
