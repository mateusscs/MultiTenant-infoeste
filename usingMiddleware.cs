namespace CursoInfoeste
{
    using Microsoft.AspNetCore.Builder;
    public static class usingMiddleware
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder) 
        {
            return builder.UseMiddleware<TenantMiddleware>();
        }
    }  
}
