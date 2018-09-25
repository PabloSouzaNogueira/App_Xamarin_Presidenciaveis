using Presidenciaveis.Domain.Candidatos;
using Presidenciaveis.Services;
using Presidenciaveis.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presidenciaveis.ViewModels
{
    public class DescricaoCandidatoPageViewModel : ViewModelBase
    {
        private readonly ICandidatoService CandidatoService;

        public DescricaoCandidatoPageViewModel(ICandidatoService candidatoService)
        {
            CandidatoService = candidatoService;
        }

        private Candidato candidato;
        public Candidato Candidato
        {
            get { return candidato; }
            set { SetProperty(ref candidato, value); }
        }

    }
}
