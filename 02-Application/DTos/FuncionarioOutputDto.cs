using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Application.DTos
{
    public class FuncionarioOutputDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } 
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Departamento { get; set; }
        public bool Ativo { get; set; }
    }
}
