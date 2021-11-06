
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace T3Calidad_N00024035.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo es obligatorio")]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }
        public List<Nota> Notas { get; set; }
     
    }
}
