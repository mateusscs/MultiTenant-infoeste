using CursoInfoeste.Abstractions.Repositories;
using CursoInfoeste.Banco.Repositories.Base;
using CursoInfoeste.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoInfoeste.Banco.Repositories
{
    public class CashRegisterRepository : BaseRepository<CashRegister>, ICashRegisterRepository
    {
        public CashRegisterRepository(CursoInfoesteContext context) : base(context)
        {
        }

        public async Task<CashRegister> GetByNumberAsync(int number, CancellationToken cancellationToken)
        {
            return await _repository.FirstOrDefaultAsync(x => x.Number == number);
        }
    }
}
