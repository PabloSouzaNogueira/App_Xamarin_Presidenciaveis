using CommonServiceLocator;
using Presidenciaveis.Domain.Candidatos;
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
	public partial class DescricaoCandidatoPage : ContentPage
	{
		public DescricaoCandidatoPage (Candidato candidato)
		{
			InitializeComponent ();
            var viewModel = ServiceLocator.Current.GetInstance<DescricaoCandidatoPageViewModel>();
            viewModel.Candidato = candidato;
            BindingContext = viewModel;
        }
	}
}