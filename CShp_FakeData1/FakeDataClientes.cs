using Bogus;
using System.Collections.Generic;

namespace CShp_FakeData1
{
    public static class FakeDataClientes
    {
        public static List<Cliente> ListaClientesFake()
        {
            var clienteFaker = new Faker<Cliente>("pt_BR")
                .RuleFor(c => c.Id, f => f.IndexFaker)
                .RuleFor(c => c.Nome, f => f.Name.FullName(Bogus.DataSets.Name.Gender.Female))
                .RuleFor(c => c.Email, f => f.Internet.Email(f.Person.FirstName).ToLower())
                .RuleFor(c => c.Telefone, f => f.Person.Phone)
                .RuleFor(c => c.Endereco, f => f.Address.StreetAddress())
                .RuleFor(c => c.Nascimento, f => f.Date.Recent(100))
                .RuleFor(c => c.Sexo, f => f.PickRandom(new string[] { "masculino", "feminino" }))
                .RuleFor(c => c.Ativo, f => f.PickRandomParam(new bool[] { true, true, false }))
                .RuleFor(o => o.Renda, f => f.Random.Decimal(500, 2000));
            var clientes = clienteFaker.Generate(10);

            return clientes;
        }

    }
}
