using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Negocio.Entidades
{
    public class CategoriaProduto
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
