using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MicrosoftIdentity.Models
{
    public class Empresa
    {
        [Key]
        public int idEmpresa { get; set; }
        public string nome { get; set; }
    }
}