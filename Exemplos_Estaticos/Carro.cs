using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Estaticos
{
    class Carro
    {
        //Atributo não estatico
        private string marca;

        //acessor não estatico
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        //atributo estatico
        public static byte numeroDeRodas = 4;

        public void Locomover()
        {
            Console.WriteLine("O carro está andando");
        }
    }
}
