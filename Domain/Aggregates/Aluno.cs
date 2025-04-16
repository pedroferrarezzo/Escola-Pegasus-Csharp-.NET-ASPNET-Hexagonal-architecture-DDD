using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggregates
{
    public class Aluno : AggregateRoot
    {
        public List<HistoricoAcademico> HistoricosAcademicos { get; private set; }
    }
}
