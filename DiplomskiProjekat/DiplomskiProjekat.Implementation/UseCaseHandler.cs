using DiplomskiProjekat.Application.Dto;
using DiplomskiProjekat.Application.Loggers;
using DiplomskiProjekat.Application.UseCases;
using DiplomskiProjekat.Implementation.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Implementation
{
    public class UseCaseHandler
    {
        private IExceptionLogger _logger;
        private IUser _user;
        private IUseCaseLogger _useCaseLogger;

        public UseCaseHandler(IExceptionLogger logger, IUser user, IUseCaseLogger useCaseLogger)
        {
            _logger = logger;
            _user = user;
            _useCaseLogger = useCaseLogger;
        }

        public void HandleCommand<TRequest>(ICommand<TRequest> request, TRequest data)
        {
            try
            {
                HandleLoggingAndAuthorization(request, data);
                var sw = new Stopwatch();
                sw.Start();
                request.Execute(data);
                sw.Stop();

                Console.WriteLine("Command name: " + request.UseCaseName + ", Duration: " + sw.ElapsedMilliseconds + "ms");
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
                throw;
            }
        }

        public TResponse HandleQuery<TRequest, TResponse>(IQuery<TRequest, TResponse> query, TRequest data)
        {
            try
            {
                HandleLoggingAndAuthorization(query, data);
                var sw = new Stopwatch();
                sw.Start();
                var response = query.Execute(data);
                sw.Stop();
                Console.WriteLine("Query name: " + query.UseCaseName + ", Duration: " + sw.ElapsedMilliseconds + "ms");

                return response;
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
                throw;
            }
        }

        private void HandleLoggingAndAuthorization<TRequest>(IUseCase useCase, TRequest data)
        {
            var isAuthorized = _user.UseCaseIds.Contains(useCase.UseCaseId);
            var log = new UseCaseLogDto
            {
                User = _user.Identity,
                ExecutionDateTime = DateTime.UtcNow,
                UseCaseName = useCase.UseCaseName,
                UserId = _user.Id,
                Data = JsonConvert.SerializeObject(data),
                IsAuthorized = isAuthorized
            };

            _useCaseLogger.Log(log);

            if (!isAuthorized)
            {
                throw new ForbiddenUseCaseExecutionException(useCase.UseCaseName, _user.Identity);
            }
        }
    }
}
