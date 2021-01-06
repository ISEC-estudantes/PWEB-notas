using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MicrosoftIdentity.Models
{
    public class ProdutoMetaData
    {
        [MaxLength(200)]
        [Index(IsUnique = true)]
        public string Nome { get; set; }
        

        [MaxLength(500)]
        public string imagem { get; set; }
    }
}