# Polimorfismo

```c#
using System ;
class ControleDePonto
{
public void RegistraEntrada ( Gerente g )
{
DateTime agora = DateTime . Now ;
string horario = String . Format ( " {0: d / M / yyyy HH : mm : ss } " , agora ) ;
System . Console . WriteLine ( " ENTRADA : " + g . Codigo ) ;
System . Console . WriteLine ( " DATA : "
+ horario ) ;
}
public void RegistraSaida ( Gerente g )
{
DateTime agora = DateTime . Now ;
string horario = String . Format ( " {0: d / M / yyyy HH : mm : ss } " , agora ) ;
System . Console . WriteLine ( " SAÍDA : " + g . Codigo ) ;
System . Console . WriteLine ( " DATA : " + horario ) ;
}
}
```


```c#

using System ;

class ControleDePonto
{

    public void RegistraEntrada ( Funcionario f )

{

DateTime agora = DateTime . Now ;
string horario = String . Format ( " {0: d / M / yyyy HH : mm : ss } " , agora ) ;

System . Console . WriteLine ( " ENTRADA : " + f . Codigo ) ;

System . Console . WriteLine ( " DATA : "
+ horario ) ;

}

public void RegistraSaida ( Funcionario f )
{

DateTime agora = DateTime . Now ;

string horario = String . Format ( " {0: d / M / yyyy HH : mm : ss } " , agora ) ;

System . Console . WriteLine ( " SAÍDA : " + f . Codigo ) ;

System . Console . WriteLine ( " DATA : " + horario ) ;

 }
}
```
# A capacidade de tratar objetos criados a partir das classes específicas como objetos de uma classe genérica é chamada de polimorfismo.