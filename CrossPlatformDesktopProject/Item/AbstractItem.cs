namespace Sprint2
{
    public abstract class AbstractItem : AbstractGameObject, IItem
    {
        public override Enumerations.GameObjectType GameObjectType { get; set; } =  Enumerations.GameObjectType.ItemInstant;

        public virtual void PickUp(IPlayer user)
        {
            IsDestructable = true;
        }
    }
}
