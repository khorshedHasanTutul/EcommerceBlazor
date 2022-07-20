namespace EcommerceWebAsmb.Server.Services.CacheService
{
    public interface IcacheService
    {
        public Player[] GetCachePlayers();
        public void AddCachePlayers(Player[] players);
    }
}
