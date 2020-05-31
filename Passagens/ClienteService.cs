using System.Collections.Generic;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public Cliente Buscar(string nome)
        {
            var dao = new ClienteDao();
            return dao.Buscar(nome);
        }

        public bool Add(string nome, string cpf)
        {
            var c = new Cliente
            {
                Nome = nome,
                Cpf = cpf
            };

            var dao = new ClienteDao();
            dao.Add(c);

            return true;
        }

        public List<Cliente> GetClientes()
        {
            return ClienteDao.clientes;
        }
    }
}
