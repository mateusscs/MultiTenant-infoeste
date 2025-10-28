namespace CursoInfoeste.Models.Responses
{
    public class CashRegisterResponse
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int TenantId { get; set; }
        public bool IsOpen { get; set; }
    }
}
