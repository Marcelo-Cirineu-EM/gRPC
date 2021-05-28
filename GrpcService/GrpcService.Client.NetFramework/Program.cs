using System;
using Grpc.Core;
using GrpcService.Grpc;
using System.Threading.Tasks;

namespace GrpcService.Client.NetFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = new Channel("localhost", 5000, ChannelCredentials.Insecure);
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Greeter Client .NET Framework" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
