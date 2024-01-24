using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Application.UseCases
{
    public interface IQuery<TRequest,TResponse> : IUseCase
    {
        public TResponse Execute(TRequest request);
    }
}
