using System.ComponentModel.DataAnnotations.Schema;

namespace Inscripciones.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        [NotMapped]
        public string Carreras
        {
            get { return $"{Nombre}"?? string.Empty; }
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}