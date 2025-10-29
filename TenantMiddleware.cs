using CursoInfoeste.Services;

namespace CursoInfoeste
{
    public class TenantMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly Persistencia _persistencia;

        public TenantMiddleware(RequestDelegate next)
        {
            _next = next;
            
        }

        public async Task InvokeAsync(HttpContext context, Persistencia persistencia)
        {
            

            var tenantId = context.Request.Headers["TenantId"].ToString();
            if(!string.IsNullOrEmpty(tenantId))
                persistencia.TenantId = int.Parse(tenantId);
            Console.WriteLine("Antes do proximo middleware");

            await _next(context);

            Console.WriteLine("Depois do proximo middleware");
        }
    }
}
