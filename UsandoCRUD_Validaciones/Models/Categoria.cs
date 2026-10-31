using System.ComponentModel.DataAnnotations;
namespace UsandoCRUD_Validaciones.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public int Orden { get; set; }
        public string Descripcion { get; set; }

    }
}
