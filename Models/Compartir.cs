using T3Calidad_N00024035.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3Calidad_N00024035.Models
{
    public class Compartir
    {
        public int Id { get; set; }
        public int IdNota { get; set; }
        public int IdUsuario { get; set; }
        public int IdAmigo { get; set; }
        public Usuario Usuarios { get; set; }
        public Nota Notas { get; set; }
    }
}
