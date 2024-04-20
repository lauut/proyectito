using System.ComponentModel.DataAnnotations;

namespace proyectito.Models
{
    public class usuario
    {
        [Key]
        public int id_usuario {  get; set; }
        public string nombre_usuario { get; set; }
        public string contraseña { get; set; }
        public string direccion { get; set;}
        public string genero { get; set; }
        public string pasatiempos {  get; set; }
        public string curso { get; set;}
        public int rol_id {  get; set; }
        public string conocimientos { get; set; }

    }
}
