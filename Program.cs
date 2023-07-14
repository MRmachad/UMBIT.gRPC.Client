
using Grpc.Net.Client;
using UMBIT.gRPC.Serve;

class Program
{
    static async Task Main(string[] args)
    {
        var channel = GrpcChannel.ForAddress("https://localhost:7105");
        var client =  new Greeter.GreeterClient(channel);
        var reply = await client.SayHelloAsync(
                        new HelloRequest { Name = "Leonardo Machado" });
        Console.WriteLine("Saudacao: " + reply.Message);
        Console.WriteLine("Pressione qualquer coisa para sair...");
        Console.ReadKey();
    }
}