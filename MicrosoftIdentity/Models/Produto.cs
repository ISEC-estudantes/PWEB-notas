using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MicrosoftIdentity.Models
{
    public class Produto
    {
        [Key]
        public int IDProduto { get; set; }        
        public string Nome { get; set; }
        public float Preco { get; set; }        
        public string imagem { get; set; }
    }
}