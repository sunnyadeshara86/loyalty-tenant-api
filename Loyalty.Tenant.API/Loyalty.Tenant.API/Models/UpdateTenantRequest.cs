namespace Loyalty.Tenant.API.Models
{
	public class UpdateTenantRequest
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public string Currency { get; set; }
		public bool Active { get; set; }
	}
}
