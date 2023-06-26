using Grpc.Core;
using GrpcGreeter;

namespace GrpcGreeter.Services;

public class EmployeeDirectoryService : EmployeeService.EmployeeServiceBase
{
    private readonly ILogger<EmployeeDirectoryService> _logger;
    public EmployeeDirectoryService(ILogger<EmployeeDirectoryService> logger)
    {
        _logger = logger;
    }

    public override Task<ID> CreateItem(Employee request, ServerCallContext context)
    {
        _logger.LogInformation("CreateItem : Got {0}", request.Id);
        return Task.FromResult(new ID
        {
            Id = "Hello " + request.Name
        });
    }

    public override Task<Employee> ReadItem(ID request, ServerCallContext context)
    {
         _logger.LogInformation("ReadItem : Got {0}", request.Id);
        return Task.FromResult(new Employee
        {
            Id = "Hello " + request.Id
        });
    }

        public override Task<ID> UpdateItem(Employee request, ServerCallContext context)
    {
         _logger.LogInformation("UpdateItem : Got {0}", request.Id);
        return Task.FromResult(new ID
        {
            Id = "Hello " + request.Id
        });
    }
        public override Task<ID> DeleteItem(ID request, ServerCallContext context)
    {
         _logger.LogInformation("DeleteItem : Got {0}", request.Id);
        return Task.FromResult(new ID
        {
            Id = "Hello " + request.Id
        });
    }
}
