using EcommerceWebAsmb.Server.Services.CacheService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebAsmb.Server.Controllers
{
    public class CacheController : BaseController
    {
        private readonly IcacheService _cacheService;

        public CacheController(IcacheService cacheService)
        {
            _cacheService = cacheService;
        }
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return _cacheService.GetCachePlayers();
        }
    }
}
