using Grpc.Net.Client;
using Client;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7160");
var client = new Diario.DiarioClient(channel);
var reply = await client.RecuperarDiarioAsync(
                  new Recuperar { IdDiario = "1" });
Console.WriteLine(reply);