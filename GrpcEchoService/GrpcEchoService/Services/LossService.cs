using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrpcEchoService.Services
{
    public class LossService : Loss.LossBase
    {
        private readonly ILogger<LossService> _logger;
        public LossService(ILogger<LossService> logger)
        {
            _logger = logger;
        }

        public override Task<CountIntegerResponse> CountInteger(CountIntegerRequest request, ServerCallContext context)
        {
            var response = new CountIntegerResponse();
            for (int i = 0; i < request.Count; i++)
            {
                response.Numbers.Add(1);
            }

            return Task.FromResult(response);
        }

        public override Task<GetEventResultResponse> GetEventResult(GetResultRequest request, ServerCallContext context)
        {
            var random = new Random();

            var response = new GetEventResultResponse
            {
                AnalysisSid = request.AnalysisSid,
            };

            for (int i = 0; i < request.AnalysisSid; i++)
            {
                response.Result.Add(new EventResult
                {
                    PerilSetCode = 4,
                    YearId = random.Next(request.AnalysisSid),
                    ModelCode = random.Next(255),
                    EventId = random.Next(),
                    Gross = random.NextDouble(),
                    GroundUp = random.NextDouble(),
                    Retained = random.NextDouble(),
                    PreCatNet = random.NextDouble()
                });
            }

            return Task.FromResult(response);
        }
    }
}
