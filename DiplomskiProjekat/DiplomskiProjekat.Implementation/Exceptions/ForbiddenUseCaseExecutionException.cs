using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Implementation.Exceptions
{
    public class ForbiddenUseCaseExecutionException : Exception
    {
        public ForbiddenUseCaseExecutionException(string UseCaseName, string user)
            :base($"User {user} has tried to execute {UseCaseName} without being authorized to do so.")
        {
            
        }
    }
}
