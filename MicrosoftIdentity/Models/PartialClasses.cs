using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicrosoftIdentity.Models
{
    public class PartialClasses
    {

        [MetadataType(typeof(ProdutoMetaData))]
        public partial class Produto
        {

        }
    }
}