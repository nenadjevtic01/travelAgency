using DiplomskiProjekat.Application.Dto;
using DiplomskiProjekat.Application.UseCases;
using DiplomskiProjekat.DataAccess;
using DiplomskiProjekat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Implementation.Loggers
{
    public class UseCaseLogger : IUseCaseLogger
    {
        private DiplomskiProjekatContext _context;

        public UseCaseLogger(DiplomskiProjekatContext context)
        {
            _context= context;
        }
        public IEnumerable<UseCaseLogDto> GetLogs(UseCaseLogSearchDto search)
        {
            throw new NotImplementedException();
        }

        public void Log(UseCaseLogDto log)
        {
            var auditLog = new AuditLog
            {
                UserId = log.UserId,
                Name = log.User,
                UseCaseName = log.UseCaseName,
                ExecutionDate = log.ExecutionDateTime,
                Data = log.Data,
                IsAuthorized = log.IsAuthorized
            };

            _context.AuditLog.Add(auditLog);
            _context.SaveChanges();
        }
    }
}
