using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MicrosoftIdentity.Models
{
    public class Compra
    {
        [Key]
        public int IDCompra { get; set; }
        public DateTime DataDaCompra { get; set; }
        //public int IDProduto { get; set; }
        //public string  userId { get; set; }
        //public virtual Produto Produto { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
      
        
    }
}