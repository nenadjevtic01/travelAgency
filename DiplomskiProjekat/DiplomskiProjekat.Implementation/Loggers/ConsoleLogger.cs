using DiplomskiProjekat.Application.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Implementation.Loggers
{
    public class ConsoleLogger : IExceptionLogger
    {
        public void Log(Exception ex)
        {
            Console.WriteLine("Exception occured at: " + DateTime.UtcNow.AddHours(2));
            Console.WriteLine("Exception message: " + ex.Message);
        }
    }
}
