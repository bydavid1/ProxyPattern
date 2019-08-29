using DLL.Models;
using DLL.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console.Class
{
    public class ProxyRepository:IRepository
    {
        public List<Persona> GetAll()
        {
            Loading();
            return SingletonRepository.Instancia.Repository.GetAll();
        }

        public Persona GetById(int id)
        {
            Loading();
            return SingletonRepository.Instancia.Repository.GetById(id);
        }

        public bool PersonOperation(Persona item, Facade.Operacion operacion)
        {
            Loading();
            return SingletonRepository.Instancia.Repository.PersonOperation(item, operacion);
        }

        private void Loading()
        {
            System.Console.WriteLine("Cargando...");
            Thread.Sleep(4000);
            System.Console.Clear();

        }
    }
}
