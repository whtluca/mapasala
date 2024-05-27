using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Entidade
{
    class SalasEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NumComputadores { get; set; }
        public bool IsLab { get; set; }
        public int NumCadeiras { get; set; }
        public bool Disponivel { get; set; }
    }
}
