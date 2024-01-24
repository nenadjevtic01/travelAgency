using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomskiProjekat.Domain
{
    public class UseCase
    {
        public int UseCaseId { get; set; }
        public string UseCaseName { get; set; }
        public string UseCaseDescription { get; set;}

        public virtual ICollection<UserUseCase> Users { get; set; } = new List<UserUseCase>();
    }
}
