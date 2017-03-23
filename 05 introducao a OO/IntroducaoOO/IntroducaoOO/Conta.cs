using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoOO
{
    class Conta
    {
       public int codigoConta;
       public String titularConta ;
       public double saldo;

       bool sacar()
        {
            this.saldo -= 50;
            return true;
        }


    }
}
