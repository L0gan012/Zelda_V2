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

<<<<<<< Updated upstream
        public virtual void PickUp(ILink link)
=======
        public virtual void PickUp(IPlayer link)
>>>>>>> Stashed changes
        {
            //must make abstract later, every item should implement its own version
            throw new NotImplementedException();
        }



    }
}
