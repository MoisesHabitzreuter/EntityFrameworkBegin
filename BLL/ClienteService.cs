using BLL.Interfaces;
using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteService : IClienteService
    {
        public void Insert(Cliente cliente)
        {
            //Validar
            using (EstacionamentoDbContext db = new EstacionamentoDbContext())
            {
                Cliente c = new Cliente()
                {
                    Nome = "Danizinho Bernart",
                    Ativo = true,
                    CPF = "901.917.069-49",
                    DataNascimento = DateTime.Now.AddYears(-25)
                };
                Vaga v = new Vaga()
                {
                    EhCoberta = true,
                    EhPreferencial = true,
                    TipoVaga = Entity.Enums.TipoVeiculo.Helicoptero,
                    VagaLivre = true
                };
                
                db.Clientes.Add(c);
                db.Vagas.Add(v);
                db.SaveChanges();
            }
        }
    }
}
