using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MicrosoftIdentity.Models
{
    public class CompraProduto
    {
        [Key]
        public int IDCompraProduto { get; set; }
        public int IDCompra { get; set; }
        public int IDProduto { get; set; }
        public int Quantidade { get; set; }


        public virtual Compra Compra { get; set; }
        public virtual Produto Produto { get; set; }



        
    }
}