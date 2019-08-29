
namespace PProxy.Class
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Acr.UserDialogs;
    using DLL.Models;
    using DLL.Patterns;
    public class ProxyRepository : IRepository
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
        private async void Loading()
        {
            using (UserDialogs.Instance.Loading("Cargando...", null, null, true, MaskType.Black))
            {
                await Task.Delay(4000);
                }
        }
    }
}
