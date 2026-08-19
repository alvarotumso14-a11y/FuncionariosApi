using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Domain.Entities
{
    public class Funcionario
    {
           public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salario { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
