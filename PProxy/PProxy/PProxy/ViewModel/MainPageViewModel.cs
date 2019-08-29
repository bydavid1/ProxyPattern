using DLL.Models;
using DLL.Patterns;
using GalaSoft.MvvmLight.Command;
using PProxy.Class;
using PProxy.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PProxy.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Atributos
        private ObservableCollection<Persona> personas;
        private bool isRefresh;
        #endregion

        #region Propiedades
        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set
            {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChange("Personas");
            }
        }

        public bool IsRefresh
        {
            get { return isRefresh; }
            set
            {
                if (isRefresh == value)
                {
                    return;
                }
                isRefresh = value;
                OnPropertyChange("IsRefresh");
            }
        }
        #endregion

        #region Constructor
        public MainPageViewModel()
        {
            Personas = new ObservableCollection<Persona>();
            getLista();
        }
        #endregion

        #region Comandos
         public ICommand Refresh
        {
            get
            {
                return new RelayCommand(getLista);
            }
        }

        public ICommand NewPerson
        {
            get
            {
                return new RelayCommand(newPerson);
            }
        }

        #endregion

        #region Metodos

        private void newPerson()
        {
            Application.Current.MainPage.Navigation.PushAsync(new NewPerson());
        }
        public void getLista()
        {
            IRepository datos = new ProxyRepository();
            var tlista = new ObservableCollection<Persona>();
            datos.GetAll().ForEach(item => tlista.Add(item));
            Personas = tlista;
            isRefresh = false;
        }
        #endregion
    }
}
