using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaAPIs.Models
{
    // Criei as models dos produtos as quais serão pegas da API 
    public class Produto
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quant { get; set; }
        public string Categoria { get; set; }
        public string Img { get; set; }
    }
}
