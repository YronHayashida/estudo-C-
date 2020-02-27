using System;

namespace Estudo
{
    class Program
    {
        static void Main()
        {
            VeiculoTerrestre carro = new Carro();
            VeiculoTerrestre veiculoTerrestre = new VeiculoTerrestre();
            VeiculoAereo aviao = new VeiculoAereo();
            VeiculoAereo tecoteco = new Tecoteco();

            Console.WriteLine($"Valor: {carro.Valor = 100}");
            Console.WriteLine($"Ano:{carro.Ano = 2020}");
            Console.WriteLine($"Acelera:{carro.Acelerar(1)}");
            Console.WriteLine($"Freia:{carro.Freiar(8)}");
            Console.WriteLine($"Tem Tração?:{carro.Tracao(true)}");
            Console.WriteLine($"Som da buzina:{carro.Buzinar()}");
            Console.WriteLine("");

            Console.WriteLine($"Valor: {veiculoTerrestre.Valor = 100}");
            Console.WriteLine($"Ano:{veiculoTerrestre.Ano = 2020}");
            Console.WriteLine($"Acelera:{veiculoTerrestre.Acelerar(1)}");
            Console.WriteLine($"Freia:{veiculoTerrestre.Freiar(8)}");
            Console.WriteLine($"Tem Tração?:{veiculoTerrestre.Tracao(true)}");
            Console.WriteLine($"Som da buzina:{veiculoTerrestre.Buzinar()}");
            Console.WriteLine("");

            Console.WriteLine($"Valor: {aviao.Valor = 100}");
            Console.WriteLine($"Ano:{aviao.Ano = 2020}");
            Console.WriteLine($"Acelera:{aviao.Acelerar(1)}");
            Console.WriteLine($"Freia:{aviao.Freiar(8)}");
            Console.WriteLine($"Som da buzina:{aviao.Buzinar()}");
            tecoteco.AceleracaoMax(400);
            Console.WriteLine($"esta sobreaquecendo?:{aviao.AceleracaoMaxima}");
            Console.WriteLine($"esta apto para decolar?:{aviao.funcionando(true)}");
            Console.WriteLine("");

            Console.WriteLine($"Valor: {tecoteco.Valor = 100}");
            Console.WriteLine($"Ano:{tecoteco.Ano = 2020}");
            Console.WriteLine($"Acelera:{tecoteco.Acelerar(1)}");
            Console.WriteLine($"Freia:{tecoteco.Freiar(8)}");
            Console.WriteLine($"Som da buzina:{tecoteco.Buzinar()}");
            tecoteco.AceleracaoMax(400);
            Console.WriteLine($"esta sobreaquecendo?:{tecoteco.AceleracaoMaxima}");
            Console.WriteLine($"esta apto para decolar?:{tecoteco.funcionando(true, false)}");

            Console.WriteLine("");
        }
    }
}
