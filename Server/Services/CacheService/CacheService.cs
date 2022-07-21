using Microsoft.Extensions.Caching.Memory;

namespace EcommerceWebAsmb.Server.Services.CacheService
{
    public class CacheService : IcacheService
    {
        private const string key = "player_cache";
        private readonly IMemoryCache _memoryCache;

        public CacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public void AddCachePlayers(Player[] players)
        {
            var options = new MemoryCacheEntryOptions
            {
                SlidingExpiration = TimeSpan.FromSeconds(30),
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(90)
            };

            _memoryCache.Set<Player[]>(key, players, options);

        }

        public Player[] GetCachePlayers()
        {
            Player[] players;
            if (!_memoryCache.TryGetValue(key, out players))
            {
                players = new Player[]
                {
                    new Player {UserName = "Messi", Jerseynumber= 10},
                     new Player {UserName = "Ronaldo", Jerseynumber = 7}
                };
                AddCachePlayers(players);
            }
            return players;
        }
    }
}
