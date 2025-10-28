using CursoInfoeste.Models;

namespace CursoInfoeste.Abstractions.Repositories
{
    public interface ICashRegisterRepository : IRepository<CashRegister>
    {
        Task<CashRegister> GetByNumberAsync(int tenantId,int number, CancellationToken cancellationToken);
    }
}
