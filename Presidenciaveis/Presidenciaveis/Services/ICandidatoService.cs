using Presidenciaveis.Domain.Candidatos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Presidenciaveis.Services
{
    public interface ICandidatoService
    {
        Task<Candidato> Find(string id);
        Task<IEnumerable<Candidato>> GetAll();
    }
}
