using BeetleX.Redis;
using Microsoft.Extensions.DependencyInjection;
using POCRedis.Consumers;

namespace POCRedis.Configurations
{
    public static class RegisConfiguration
    {
        public static void AddRedis(this IServiceCollection services)
        {
            Redis.Default.DataFormater = new JsonFormater();
            Redis.Default.Host.AddWriteHost("redis");

            var personConsumer = new PersonConsumer();
            services.AddSingleton(personConsumer);
        }
    }
}
