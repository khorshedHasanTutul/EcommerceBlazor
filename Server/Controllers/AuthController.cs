using EcommerceWebAsmb.Server.Services.AuthService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebAsmb.Server.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>>Register(UserRegister request)
        {
            var response = await _authService.Register(new User
            {
                Email = request.Email
            },
            request.Password
            );

            if(!response.status)
            {
                return BadRequest(response);
            }
           
                return Ok(response);    
        
        }
    }
}
