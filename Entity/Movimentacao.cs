using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Movimentacao
    {
        public int ID { get; set; }
        public int VagaID { get; set; }
        public virtual Vaga Vaga { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public int? ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Cor { get; set; }
        public double ValorTotal { get; set; }

    }
}
