namespace Loyalty.Tenant.API.Models
{
	public class GetTenantByIdResponse
	{
        public string StoreId { get; set; }
        public string Code { get; set; }
        public string Currency { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}
