namespace Dominio
{
    public class Articulos
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int idMarca { get; set; }
        public int idCategoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; } //Ver Decimal - Float

    }
}
