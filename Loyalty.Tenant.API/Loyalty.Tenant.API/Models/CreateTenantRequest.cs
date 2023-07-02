namespace Loyalty.Tenant.API.Models
{
	public class CreateTenantRequest
	{
        public string Code { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public bool Active { get; set; }
    }
}
