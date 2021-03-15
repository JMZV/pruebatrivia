using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebatrivia.Models
{
    public class Preguntas
    {
        public int Id { get; set; }
        public string Detalle { get; set; }

        public int Valor { get; set; }
        public int CategoriasId { get; set; }
        public Categorias Categoria { get; set; }
    }
}
