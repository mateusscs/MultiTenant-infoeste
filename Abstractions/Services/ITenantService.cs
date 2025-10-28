using CursoInfoeste.Models.Requests;
using CursoInfoeste.Models.Responses;

namespace CursoInfoeste.Abstractions.Services
{
    public interface ITenantService
    {
        Task<TenantResponse> Get(int id, CancellationToken cancellationToken);
        Task<IEnumerable<TenantResponse>> List(CancellationToken cancellationToken);
        Task<TenantResponse> Create(CreateTenantRequest request, CancellationToken cancellationToken);
        Task<TenantResponse> Update(int id, UpdateTenantRequest request, CancellationToken cancellationToken);
        Task Delete(int id, CancellationToken cancellationToken);
    }
}
