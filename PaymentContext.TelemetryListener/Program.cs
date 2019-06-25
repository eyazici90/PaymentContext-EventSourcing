using Autofac;
using PaymentContext.TelemetryListener.Consumers;
using Galaxy.Bootstrapping;
using Galaxy.RabbitMQ.Bootstrapper;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace PaymentContext.TelemetryListener
{
    class Program
    {
        static void Main(string[] args) =>
            MainAsync(args).ConfigureAwait(false)
                .GetAwaiter().GetResult();
        
        static async Task MainAsync(string[] args)
        {
            Console.WriteLine($"{DateTime.Now} : Listener Started !!!"); 

            var containerBuilder = GalaxyCoreModule.New
                 .RegisterGalaxyContainerBuilder()
                     .UseGalaxyCore()
                     .UseGalaxyRabbitMQ(conf =>
                     {
                         conf.Username = "guest";
                         conf.Password = "guest";
                         conf.HostAddress = "rabbitmq://localhost/";
                         conf.QueueName = "PaymentContextSub";
                     }, typeof(TransactionCreatedConsumer).Assembly);


            var container = containerBuilder.InitializeGalaxy();

            var busControl = container.Resolve<IBusControl>();

            await  busControl.StartAsync();

            Console.ReadLine();
        }

    }
}
