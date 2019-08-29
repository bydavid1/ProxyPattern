using DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Patterns
{
    public class Repository : IRepository
    {
        #region Atributos
        private int index;
        #endregion

        #region Constructor
        public Repository()
        {
            Persona.dbPersonas = new List<Persona>(); 

            #region Objetos
            Persona p1 = new Persona()
            {
                Id = 1,
                Nombre = "Juan",
                Apellido = "Ramones",
                Direccion = "Mariona",
                Edad = 60

            };

            Persona p2 = new Persona()
            {
                Id = 2,
                Nombre = "Sanchez",
                Apellido = "Ceren",
                Direccion = "San Salvador",
                Edad = 65

            };

            Persona p3 = new Persona()
            {
                Id = 3,
                Nombre = "Tony",
                Apellido = "Saca",
                Direccion = "Mariona",
                Edad = 55

            };
           

            Persona.dbPersonas.Add(p1);
            Persona.dbPersonas.Add(p2);
            Persona.dbPersonas.Add(p3);
            
            #endregion

        }
        #endregion


        #region Metodos
        public List<Persona> GetAll()
        {
            return Persona.dbPersonas;
        }

        public Persona GetById(int id)
        {
            return Persona.dbPersonas.Find(p => p.Id.Equals(id));
        }

        public bool PersonOperation(Persona item, Facade.Operacion operacion)
        {
            try
            {
              
                switch (operacion)
                {
                    case Facade.Operacion.Save:
                        index = Persona.dbPersonas.Count - 1;
                        if (index <= 0)
                        {
                            item.Id = 1;
                        }
                        else
                        {
                            item.Id = (Persona.dbPersonas[index].Id) + 1;
                            Persona.dbPersonas.Add(item);
                        }
                        return true;

                    case Facade.Operacion.Update:
                        index = Persona.dbPersonas.FindIndex(p => p.Id.Equals(item.Id));
                        Persona.dbPersonas[index] = item;
                        return true;

                    case Facade.Operacion.Delete:
                        index = Persona.dbPersonas.FindIndex(p => p.Id.Equals(item.Id));
                        Persona.dbPersonas.RemoveAt(index);
                        return true;

                    default:
                        return false;
                }


            }
            catch (Exception)
            {

                return false;
            }
        }

      
        #endregion
    }
}


