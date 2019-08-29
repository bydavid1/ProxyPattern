using PProxy.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PProxy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewPerson : ContentPage
	{
		public NewPerson ()
		{
			InitializeComponent ();
            BindingContext = new NewPersonViewModel();
		}
	}
}