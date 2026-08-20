using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTos
{
    public class FuncionarioInputDto
    {
        public string Nome { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public string Departamento { get; set; } = string.Empty;
    }
}
