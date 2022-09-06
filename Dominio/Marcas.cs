namespace Dominio
{
    public class Marcas
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
