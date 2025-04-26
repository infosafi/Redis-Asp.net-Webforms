using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsRedis.Helper
{
    public class RedisHelper
    {
        private static readonly Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            var options = ConfigurationOptions.Parse("127.0.0.1:6379");
            options.AllowAdmin = true;
            options.AbortOnConnectFail = false;
            options.ConnectTimeout = 5000;
            options.SyncTimeout = 5000;
            // Replace with your Redis server
            return ConnectionMultiplexer.Connect(options);
        });

        public static ConnectionMultiplexer Connection => lazyConnection.Value;
    }
}