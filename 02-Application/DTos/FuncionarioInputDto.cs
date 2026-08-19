using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Application.DTos
{
    public class FuncionarioInputDto
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Departamento { get; set; }
    }
}
