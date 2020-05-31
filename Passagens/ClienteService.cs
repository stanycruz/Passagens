using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public Cliente Buscar(string nome)
        {
            ClienteDao dao = new ClienteDao();
            return dao.Buscar(nome);
        }

        public void Add(Cliente c)
        {
            ClienteDao dao = new ClienteDao();
            dao.Add(c);
        }
    }
}
