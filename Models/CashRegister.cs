using CursoInfoeste.Models.Base;

namespace CursoInfoeste.Models
{
    public class CashRegister : BaseEntity
    {
        public int Number { get; set; }
        public int TenantId { get; set; }
        public bool IsOpen { get; set; }
        public Tenant Tenant { get; set; }
    }
}
