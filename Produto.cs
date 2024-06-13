using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosProvaB2
{
    public class Produto
    {
        public string nome { get; set; }
        public string marca { get; set; }
        public string quantidade { get; set; }

        public Produto() { }
        public Produto( string nome, string marca, string quantidade)
        {
            this.nome = nome;
            this.marca = marca;
            this.quantidade = quantidade;
        }

        
    }
}
