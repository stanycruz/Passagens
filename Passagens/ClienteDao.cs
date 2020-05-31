using System.Collections.Generic;
using System.Linq;

namespace Passagens
{
    public class ClienteDao
    {   
        private static List<Cliente> clientes = new List<Cliente>();

        public void Add(Cliente c)
        {
            ClienteDao.clientes.Add(c);
        }

        public Cliente Buscar(string nome)
        {
            var resultado = ClienteDao.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            return (Cliente)resultado;
        }
    }
}
