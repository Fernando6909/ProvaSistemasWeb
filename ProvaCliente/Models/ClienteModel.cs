using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProvaCliente.Models
{
    public class ClienteModel
    {
        [Key]
        public long ID { get; set; }

        [Required(ErrorMessage = "Favor Informe o Nome corretamente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor Informe o CPF corretamente")]
        public int CPF { get; set; }
    }
}