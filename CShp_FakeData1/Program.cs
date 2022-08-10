using System;

namespace CShp_FakeData1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var clientes = FakeDataClientes.ListaClientesFake();
            
            foreach(var cli in clientes)
            {
                Console.WriteLine(cli.Id);
                Console.WriteLine(cli.Nome);
                Console.WriteLine(cli.Email);
                Console.WriteLine(cli.Telefone);
                Console.WriteLine(cli.Endereco);
                Console.WriteLine(cli.Nascimento);
                Console.WriteLine(cli.Sexo);
                Console.WriteLine(cli.Ativo);
                Console.WriteLine(cli.Renda);
            }
            Console.ReadLine();
        }
    }
}
