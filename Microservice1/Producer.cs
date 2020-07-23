using System;
using RabbitMQ.Client;

namespace Microservice1
{
    public class Producer
    {

        public static void sendMessage(string i_TheMessage)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "queue1",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var body = System.Text.Encoding.UTF8.GetBytes(i_TheMessage);

                channel.BasicPublish(exchange: "",
                                     routingKey: "queue1",
                                     basicProperties: null,
                                     body: body);
               Console.WriteLine("Sent {0}", i_TheMessage);
            }

    
        }
    }
}
