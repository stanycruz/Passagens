using System.ServiceModel;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        Cliente Buscar(string nome);
        [OperationContract]
        void Add(Cliente c);
    }
}
