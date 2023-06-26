using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeter;

string address = "http://localhost:" + args[0];
 Console.WriteLine(address);

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress(address);

var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "GreeterClient" });
Console.WriteLine("Greeting: " + reply.Message);

var employeeClient = new EmployeeService.EmployeeServiceClient(channel);
Employee employee = new Employee { Id= "1234", Name = "Employee1234"};
ID reply1 = await employeeClient.CreateItemAsync(employee);
Console.WriteLine("Employee: " + reply1.Id);

Console.WriteLine("Exit...");
