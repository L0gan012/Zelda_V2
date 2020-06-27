﻿using System;

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

        public virtual void PickUp()
        {
            //must make abstract later, every item should implement its own version
            throw new NotImplementedException();
        }



    }
}
