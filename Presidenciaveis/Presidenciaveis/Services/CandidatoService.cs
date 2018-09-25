using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Presidenciaveis.Domain.Candidatos;
using Presidenciaveis.Infra.Data.Repository;

namespace Presidenciaveis.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly CandidatoRepository CandidatoRepository;

        public CandidatoService()
        {
            CandidatoRepository = new CandidatoRepository("Candidatos");
        }

        public Task<Candidato> Find(string id)
        {
            return CandidatoRepository.Find(id);
        }

        public Task<IEnumerable<Candidato>> GetAll()
        {
            return CandidatoRepository.GetAll();
        }
    }
}
