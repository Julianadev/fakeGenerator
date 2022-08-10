﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CShp_FakeData1
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public bool Ativo { get; set; }
        public decimal Renda { get; set; }
    }
}