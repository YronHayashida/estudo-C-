using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo
{
    abstract class Veiculo
    {
        public int Ano {get; set; }
        public float Valor { get; set; }

        public abstract string Acelerar(int forca);

        public abstract string Freiar(int forca);

        public abstract string Buzinar();

        public abstract void AceleracaoMax(int kilometroHora);
     
    }
}
