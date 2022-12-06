using System;
using System.ComponentModel.DataAnnotations;

namespace Negocio
{
    public class Funcionario
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Salario { get; set; }
    }
}
