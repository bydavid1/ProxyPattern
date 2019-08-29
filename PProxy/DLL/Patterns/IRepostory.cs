using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Patterns
{
    using DLL.Models;
    using System.Collections.Generic;

    public interface IRepository
    {
        List<Persona> GetAll();
        Persona GetById(int id);
        bool PersonOperation(Persona item, Facade.Operacion operacion);

    }
}
