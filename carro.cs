using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo
{
    class Carro : VeiculoTerrestre
    {
        public override string Acelerar(int forca)
        {
            return base.Acelerar(forca - 3);
        }

        public override string Freiar(int forca)
        {
            return base.Freiar(forca + 3);
        }
        public override string Buzinar()
        {
            return "BUUUM!!!";
        }

        public override string Tracao(bool tracao)
        {
            return tracao ? "Tem tração nas 4 rodas" : "Não tem tração";
        }
    }
}

