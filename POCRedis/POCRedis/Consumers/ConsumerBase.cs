using BeetleX.Redis;

namespace POCRedis.Consumers
{
    public abstract class ConsumerBase<TConsumer> where TConsumer : class
    {
        public ConsumerBase()
        {
            var subscribe = Redis.Subscribe();
            subscribe.Register<TConsumer>(typeof(TConsumer).FullName);
            subscribe.Receive = Execute;
            subscribe.Listen();
        }

        protected abstract void Execute(object obj, SubscribeMessage message);
    }
}
