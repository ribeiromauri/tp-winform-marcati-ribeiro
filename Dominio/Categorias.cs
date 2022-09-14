using System.ComponentModel;

namespace Dominio
{
    public class Categorias
    {
        public int ID { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
