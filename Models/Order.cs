using CursoInfoeste.Models.Base;

namespace CursoInfoeste.Models
{
    public class Order : BaseEntity
    {
        public decimal Value { get; set; }
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
