using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo
{
    class VeiculoTerrestre : Veiculo
    {
        public string AceleracaoMaxima { get; protected set; }

        public override void AceleracaoMax(int kilometroHora)
        {
            int max = 900;
            if (kilometroHora == max)
            { AceleracaoMaxima = "sobreaquecendo"; }
            else { AceleracaoMaxima = "Não esta aquecendo"; }
        }

        public override string Acelerar(int forca)
        {
            if (forca < 0)
            {
                return "Não Acelerou";
            }
            if (forca >= 0 && forca <= 3)
            {
                return "devagar";
            }
            if (forca >= 4 && forca <= 8)
            {
                return "medio";
            }
            else return "rapido";
        }

        public override string Buzinar()
        {
            return "Buzina de veiculo terrestre";
        }

        public override string Freiar(int forca)
        {
            if (forca < 0)
            {
                return "Não freiou";
            }
            if (forca >= 0 && forca <= 3)
            {
                return "Freiou de vagar";
            }
            if (forca >= 4 && forca <= 8)
            {
                return "Freiando";
            }
            else return "Freiou bruscamente";
        }

        public virtual string Tracao(bool tracao)
        {
            return tracao ? "Tem tração" : "Não tem tração";
        }
    }
}
