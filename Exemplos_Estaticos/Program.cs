using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hoje = DateTime.Now;
            
            // não posso instanciar esse objeto
            //Conversao objConv = new Conversao();
            Console.WriteLine(Conversao.ConverteMoeda(5.66f));
            Console.WriteLine(Conversao.DiaDaSemana(hoje));
            //Console.WriteLine(hoje);

            Carro meuCarro = new Carro();
            meuCarro.Marca = "Honda";

            //metodo statico
            Carro.numeroDeRodas = 3;

            //metodo dinamico
            meuCarro.Locomover();

            Console.ReadKey();
        }
    }
}
