namespace CrudTributoJusto.Models
{
    public class Item : Entity
    {
        public int Quantidade{ get; set; }

        public Produto Produto { get; set; }
    }
}
