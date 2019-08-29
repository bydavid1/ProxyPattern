using System;
using System.Collections.Generic;
using System.Text;

namespace PProxy.ViewModel
{
    public class NewPersonViewModel : BaseViewModel
    {
        #region Atributos
        private string _nombre;
        private string _apellido;
        private string _edad;
        private string _direccion;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre == value)
                {
                    return;
                }
                _nombre = value;
                OnPropertyChange("Nombre");
            }
        }

        public string Apellido
        {
            get { return _nombre; }
            set
            {
                if (_nombre == value)
                {
                    return;
                }
                _nombre = value;
                OnPropertyChange("Nombre");
            }
        }

        public string Direccion
        {
            get { return _nombre; }
            set
            {
                if (_nombre == value)
                {
                    return;
                }
                _nombre = value;
                OnPropertyChange("Nombre");
            }
        }

        public string Edad
        {
            get { return _nombre; }
            set
            {
                if (_nombre == value)
                {
                    return;
                }
                _nombre = value;
                OnPropertyChange("Nombre");
            }
        }
        #endregion

        #region Constructor
        public NewPersonViewModel()
        {

        }
        #endregion

        #region Comandos

        #endregion
    }
}
