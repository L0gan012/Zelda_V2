
namespace Sprint2
{
    public interface INPC : IGameObject
    {
        bool HasKey { get; set; }
        float DamageAmount { get; }
        bool HasHitWall { get; set; }

        void TakeDamage(float damageAmount);

       
    }
}
