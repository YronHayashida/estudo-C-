using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo
{
    class VeiculoAereo : Veiculo
    {
        public bool AceleracaoMaxima { get; protected set; }
        public override void AceleracaoMax(int kilometroHora)
        {
            int max = 900;
            if (kilometroHora == max)
            { AceleracaoMaxima = true; }
            else { AceleracaoMaxima = false; }
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
                return "decolando";
            }
            else return "Voando";
        }

        public override string Buzinar()
        {
            return "Buzina de veiculo Aereo";
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

        public string funcionando(bool motor)
        {
            return motor ? "tudo certo para decolar" : "Falha no motor, não pode decolar";
        }

        public string funcionando(bool motor, bool helice)
        {
            return motor && helice ? "Tudo certo para decolar" : "Helice ou motor com problemas, não pode decolar";
        }
    }
}
