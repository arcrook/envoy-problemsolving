using Grpc.Core;

namespace GrpcGreeter.Services;

public class ComplexApiService : ComplexService.ComplexServiceBase
{
    private readonly ILogger<ComplexApiService> _logger;

    public ComplexApiService(ILogger<ComplexApiService> logger)
    {
        _logger = logger;
    }

    public override Task<CalculateMapResponse> CalculateMap(CalculateMapRequest request, ServerCallContext context)
    {
        _logger.LogInformation("CalculateMap : Got {0}", request.Name);

        Dictionary<string, Subject> subjectDictionary = new Dictionary<string, Subject>();
        foreach (var item in request.SubjectData)
        {
            subjectDictionary.Add(item.Key, item.Value);
        }

        var reply = new CalculateMapResponse
        {
            Name = "Hello " + request.Name,
        };
        reply.SubjectData.Add(subjectDictionary);

        return Task.FromResult(reply);
    }

}