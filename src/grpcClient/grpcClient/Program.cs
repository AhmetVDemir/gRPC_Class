

using Grpc.Net.Client;
using grpcServer;

var channel = GrpcChannel.ForAddress("http://localhost:5278/");
var greetClient = new Greeter.GreeterClient(channel);

HelloReply hello =  greetClient.SayHello(new HelloRequest { Name = "Selam Ahmet" });

Console.WriteLine(hello.Message);