using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTributoJusto.Models
{
    public class Pedido : Entity
    {
        public Guid ClienteId { get; set; }

        [DisplayName("Data pedido")]
        public DateTime DataPedido { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
        public IEnumerable<Produto> ItensPedido { get; set; }

        /* EF Relations */
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
    }
}
