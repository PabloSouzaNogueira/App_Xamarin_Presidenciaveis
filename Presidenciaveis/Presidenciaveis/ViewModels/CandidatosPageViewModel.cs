using Presidenciaveis.Domain.Candidatos;
using Presidenciaveis.Services;
using Presidenciaveis.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Presidenciaveis.ViewModels
{
    public class CandidatosPageViewModel : ViewModelBase
    {
        private readonly ICandidatoService CandidatoService;
        public ObservableCollection<Candidato> Candidatos { get; set; }
        public Command AtualizarDados { get; }

        public CandidatosPageViewModel(ICandidatoService candidatoService)
        {
            CandidatoService = candidatoService;
            Candidatos = new ObservableCollection<Candidato>();
            GetCandidatos();
            AtualizarDados = new Command(ExecuteAtualizarDados);
        }

        private bool atualizando;
        public bool Atualizando
        {
            get { return atualizando; }
            set { SetProperty(ref atualizando, value); }
        }

        private async void ExecuteAtualizarDados()
        {
            Atualizando = true;
            await GetCandidatos();
            Atualizando = false;
        }

        private async Task GetCandidatos()
        {
            var candidatos = await CandidatoService.GetAll();

            if (Candidatos.Count > 0)
                Candidatos.Clear();

            foreach (var folheto in candidatos)
            {
                Candidatos.Add(folheto);
            }
        }

        private Candidato candidato;
        public Candidato Candidato
        {
            get { return candidato; }
            set { SetProperty(ref candidato, value); }
        }
    }
}
