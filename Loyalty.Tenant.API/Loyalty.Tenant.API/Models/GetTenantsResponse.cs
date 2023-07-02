namespace Loyalty.Tenant.API.Models
{
	public class GetTenantsResponse
	{
        public List<GetTenantByIdResponse> Items { get; set; }
        public SummaryResponse Total { get; set; }
    }
}
