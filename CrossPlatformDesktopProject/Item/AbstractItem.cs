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

        public virtual void PickUp(IPlayer user)
        {
            IsDestructable = true;
        }
    }
}
