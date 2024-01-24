using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiplomskiProjekat.Application.Dto;

namespace DiplomskiProjekat.Application.UseCases
{
    public interface IUseCaseLogger
    {
        public void Log(UseCaseLogDto log);
        IEnumerable<UseCaseLogDto> GetLogs(UseCaseLogSearchDto search);
    }
}
