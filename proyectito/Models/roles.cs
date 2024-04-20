using System.ComponentModel.DataAnnotations;

namespace proyectito.Models
{
    public class roles
    {
        [Key]
        public int id_rol { get; set; }
        public string rol {  get; set; }

    }
}
