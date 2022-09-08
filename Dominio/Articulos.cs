using System.ComponentModel;

namespace Dominio
{
    public class Articulos
    {
        public int ID { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Marcas Marca { get; set; }
        public Categorias Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; } //Ver Decimal - Float

    }
}
