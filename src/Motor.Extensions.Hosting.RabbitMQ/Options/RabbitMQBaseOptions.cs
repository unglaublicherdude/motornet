using System;

namespace Motor.Extensions.Hosting.RabbitMQ.Options
{
    public abstract record RabbitMQBaseOptions
    {
        public string Host { get; set; } = string.Empty;
        public int Port { get; set; } = 5672;
        public string VirtualHost { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public TimeSpan RequestedHeartbeat { get; set; } = TimeSpan.FromSeconds(60);
    }
}
