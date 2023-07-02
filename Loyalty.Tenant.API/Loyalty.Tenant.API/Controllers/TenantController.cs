using Loyalty.Tenant.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loyalty.Tenant.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TenantController : ControllerBase
	{
		#region Private Members

		private readonly ILogger<TenantController> _logger;

		#endregion

		#region Constructors

		public TenantController(ILogger<TenantController> logger)
		{
			_logger = logger;
		}

		#endregion

		#region Get Methods

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(GetTenantsResponse))]
		[ProducesResponseType(400, Type = typeof(ValidationErrorResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult GetTenants([FromQuery] GetTenantsRequest getTenantsRequest)
		{
			return Ok(new GetTenantsResponse());
		}

		[HttpGet]
		[Route("{id}")]
		[ProducesResponseType(200, Type = typeof(GetTenantByIdResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult GetTenantById(int id)
		{
			return Ok(new GetTenantByIdResponse());
		}

		#endregion

		#region Post Methods

		[HttpPost]
		[ProducesResponseType(200, Type = typeof(CreateTenantResponse))]
		[ProducesResponseType(400, Type = typeof(ValidationErrorResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult CreateTenant(CreateTenantRequest createTenantRequest)
		{ 
			return Ok(new CreateTenantResponse());
		}

		#endregion

		#region Put Methods

		[HttpPut]
		[ProducesResponseType(204)]
		[ProducesResponseType(400, Type = typeof(ValidationErrorResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult UpdateTenant(UpdateTenantRequest updateTenantRequest)
		{
			return NoContent();
		}

		#endregion
	}
}
