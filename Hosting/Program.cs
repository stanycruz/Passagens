using Passagens;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(ClienteService)))
            {
                Uri uri = new Uri("http://localhost:8080/clientes");
                host.AddServiceEndpoint(typeof(IClienteService), new BasicHttpBinding(), uri);

                try
                {
                    host.Open();
                    ExibeInformacoesServico(host);
                    Console.ReadLine();
                    host.Close();
                }
                catch (TimeoutException timeProblem)
                {
                    Console.WriteLine(timeProblem.Message);
                    Console.ReadLine();
                }
                catch (CommunicationException commProblem)
                {
                    Console.WriteLine(commProblem.Message);
                    Console.ReadLine();
                }
            }
        }

        public static void ExibeInformacoesServico(ServiceHost host)
        {
            Console.WriteLine($"{host.Description.ServiceType} on line");

            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                Console.WriteLine(se.Address);
            }
        }
    }
}
