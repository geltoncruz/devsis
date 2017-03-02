using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposPrimitivos
{
    class Program
    {
        // Enum é tipo de dado numérico
        enum Dias { dom=100,seg,ter,quar,qui,sex,sab  };

        static void Main(string[] args)
        {
            //Variáveis tipadas
            int numero = 3;
            float numero2 = 2f;
            //bool  representado por true e false
            bool certidaoDeVivo = false;
            //Cast como fortalecimento de tipo e conversão explicita
            int resultado = numero + (int) numero2;
            //string é um tipo de dado válido
            string texto = "Ola Mundo";

            Dias dia = Dias.seg;
            

            Console.WriteLine("A referencia numerica do dia : "+(int) dia);

       

            
            /*

        Console.WriteLine(numero);
            Console.WriteLine(texto);

            Console.WriteLine(texto+" Voce esta vivo? {0}", certidaoDeVivo);
            
    */

            Console.ReadLine();

            // Comentário em Cshar é escrito com // {tambem} 
            
        }
    }
}
