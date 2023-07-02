namespace Loyalty.Tenant.API.Models
{
	public class GetTenantsRequest
	{
        public string Name { get; set; }
        public string Code { get; set; }
        public string Currency { get; set; }
        public bool Active { get; set; }
        public int Page { get; set; }
        public int ItemsPerPage { get; set; }
        public string OrderBy { get; set; }
        public string OrderByDirection { get; set; }
    }
}
