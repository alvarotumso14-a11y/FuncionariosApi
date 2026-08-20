using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public string Cargo { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
    }
}
