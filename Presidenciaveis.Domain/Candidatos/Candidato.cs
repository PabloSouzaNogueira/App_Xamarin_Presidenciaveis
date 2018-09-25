using Presidenciaveis.Domain.ModelBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presidenciaveis.Domain.Candidatos
{
    public class Candidato : Entity
    {
        public string nome { get; set; }
        public string foto { get; set; }
        public string partido { get; set; }
        public int numero { get; set; }
        public string descricao { get; set; }
    }
}
