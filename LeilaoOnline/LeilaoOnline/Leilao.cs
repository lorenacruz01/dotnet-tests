using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoOnline
{
    public class Leilao
    {
        private List<Lance> _lances;
        public IEnumerable<Lance> Lances => _lances;
        public string Peca { get; private set; }
        public Lance Ganhador { get; set; }
        public Leilao(string peca)
        {
            _lances = new List<Lance>();
            Peca = peca;
        }
        public void RecebeLance(Interessado cliente, double lance)
        {
            _lances.Add(new Lance(cliente, lance));
        }
        public void IniciaPregao()
        {

        }
        public void TerminaPregao()
        {
            Ganhador = Lances.OrderBy(x => x.Valor).Last();
        }
    }
}
