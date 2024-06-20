using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace MypulseWebapi.Services
{
    public class RabbitMQService : IDisposable
    {
        private readonly IConnection connection;
        private readonly IModel channel;
        private readonly ILogger<RabbitMQService> logger;
        private readonly IHubContext<ChatHub> hubContext; // Add this
        private string queueName;

        public RabbitMQService(ILogger<RabbitMQService> logger, IHubContext<ChatHub> hubContext) // Update constructor
        {
            this.logger = logger;
            this.hubContext = hubContext; // Initialize hubContext
            var factory = new ConnectionFactory() { HostName = "localhost" };
            connection = factory.CreateConnection();
            channel = connection.CreateModel();

            channel.ExchangeDeclare(exchange: "logs", type: ExchangeType.Fanout);
            queueName = channel.QueueDeclare().QueueName;
            channel.QueueBind(queue: queueName, exchange: "logs", routingKey: "");

            logger.LogInformation("RabbitMQ connection established.");
        }

        public void Publish(string message)
        {
            try
            {
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "logs", routingKey: "", basicProperties: null, body: body);
                logger.LogInformation($"Message published: {message}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error publishing message to RabbitMQ.");
            }
        }

        public void StartConsumer()
        {
            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                logger.LogInformation($"Received message: {message}");
                // Use hubContext to send to all clients
                hubContext.Clients.All.SendAsync("ReceiveMessage", "System", message);
            };

            channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
        }

        public void Dispose()
        {
            channel?.Close();
            connection?.Close();
            logger.LogInformation("RabbitMQ connection closed.");
        }
    }
}
