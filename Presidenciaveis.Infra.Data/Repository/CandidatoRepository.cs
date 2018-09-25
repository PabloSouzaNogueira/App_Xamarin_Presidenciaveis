using Presidenciaveis.Domain.Candidatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presidenciaveis.Infra.Data.Repository
{
    public class CandidatoRepository : HerokuRepository<Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(string entidade) : base(entidade)
        {
        }
    }
}
