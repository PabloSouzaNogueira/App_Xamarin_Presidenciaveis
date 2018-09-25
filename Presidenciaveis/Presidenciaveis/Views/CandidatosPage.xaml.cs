using CommonServiceLocator;
using Presidenciaveis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Presidenciaveis.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CandidatosPage : ContentPage
	{
        CandidatosPageViewModel viewModel;
        public CandidatosPage ()
		{
			InitializeComponent ();
            var viewModel = ServiceLocator.Current.GetInstance<CandidatosPageViewModel>();
            this.viewModel = viewModel;
            BindingContext = viewModel;
        }

        private void CandidatoSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new DescricaoCandidatoPage(viewModel.Candidato));
        }
    }
}