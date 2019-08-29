

namespace DLL.Models
{
    using System.Collections.Generic;
    public class Persona
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }

        #endregion


        public static List<Persona> dbPersonas;

    }
}
