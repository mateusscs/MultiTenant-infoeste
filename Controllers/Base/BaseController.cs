using Microsoft.AspNetCore.Mvc;

namespace CursoInfoeste.Controllers.Base
{
    public class BaseController : ControllerBase
    {
        protected int TenantId
        {
            get
            {
                var tenantId = Request.Headers["TenantId"].ToString();
                return string.IsNullOrEmpty(tenantId) ? 0 : int.Parse(tenantId);
            }
        }
    }
}
